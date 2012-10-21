using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Linq;
using System.Text;
using System.IO;
using log4net;
using SKYPE4COMLib;

namespace SkypeCallingBot.SkypeEngine {
    public class CallAudioStreamServer: TcpListener {
        private static ILog logger = LogManager.GetLogger("CallAudioStreamServer");
        private static CallAudioStreamServer serverSingleton = null;
        private static int listeningPort = 61523;
        
        private Skype skype = null;
        private bool isRunning = false;
        private Thread acceptingThread = null;
 
        private CallAudioStreamServer(Skype skype): base(IPAddress.Any, listeningPort) {
            logger.Info("Singleton constructed");
            this.skype = skype;
            this.Start();
        }

        public static CallAudioStreamServer getServer(Skype skype) {
            if (serverSingleton == null)
                serverSingleton = new CallAudioStreamServer(skype);
            return serverSingleton;
        }

        public new void Start() {
            if (isRunning == true)
                return;
            isRunning = true;
            base.Start();
            acceptingThread = new Thread(new ThreadStart(clientsAcceptingThreadProc));
            acceptingThread.IsBackground = true;
            acceptingThread.Start();
            logger.Info("Started.");
        }

        public new void Start(int backLog) {
            this.Start();
        }

        public new void Stop() {
            if (!isRunning)
                return;
            isRunning = false;
            base.Stop();
            acceptingThread.Interrupt();
            acceptingThread = null;
            logger.Info("Stopped.");
        }

        public bool IsRunning {
            get {
                return isRunning;
            }
        }

        public int ListeningPort {
            get {
                return listeningPort;
            }
        }

        private void clientsAcceptingThreadProc() {
            try {
                while(true) {
                    Socket socket = AcceptTcpClient().Client;
                    logger.Info("New TCP client: " + socket.LocalEndPoint.ToString());
                    Thread readingThread = new Thread(new ParameterizedThreadStart(clientsReadingThread));
                    readingThread.IsBackground = true;
                    readingThread.Start(socket);
                }
            }
            catch (Exception) { Console.WriteLine("EXCEPTION"); }
        }

        private void clientsReadingThread(object parameter) {
            Socket socket = (Socket)parameter;
            FileStream stream = File.Open("output.dat", FileMode.Create);
            while (socket.Poll(1000 * 1000, SelectMode.SelectRead)) {
                if(socket.Available != 0) {
                    byte [] buffer = new byte [socket.Available];
                    socket.Receive(buffer, socket.Available, SocketFlags.None);
                    stream.Write(buffer, 0, socket.Available);
                    stream.Flush();
                }
                Thread.Sleep(100);
            }
            stream.Close();
            logger.Info("Client disconnected: " + socket.LocalEndPoint.ToString());
        }
    }
}
