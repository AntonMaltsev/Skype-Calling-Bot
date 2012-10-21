using System;
using System.Collections.Generic;
using System.Threading;
using log4net;
using SKYPE4COMLib;

namespace SkypeCallingBot.SkypeEngine {
    public class CallProxy {
        private static ILog logger = LogManager.GetLogger("CallProxy");
        private Call call = null;
        private Skype skype = null;

        public CallProxy(Skype skype, Call call) {
            this.call = call;
            this.skype = skype;
        }

        public bool waitForResponse(int timeOutInSeconds) {
            Semaphore responseSemaphore = new Semaphore(0, 1);
            Thread waitingThread = new Thread(new ParameterizedThreadStart(waitingForAnswerThreadProc));
            waitingThread.IsBackground = true;
            waitingThread.Start(responseSemaphore);
            logger.Info("Waiting for answer... (ID = " + call.Id + ")");
            if (! responseSemaphore.WaitOne(timeOutInSeconds * 1000) || call.Status != TCallStatus.clsInProgress)
            {
                try {
                    call.Finish();
                }
                catch(Exception) {}
                logger.Info("\tRefused (ID = " + call.Id + ")");
                return false;
            }
            skype.CallStatus += callStatusChangedEvent;
            logger.Info("\tAnswered (ID = " + call.Id + ")");
            call.OutputDevice[TCallIoDeviceType.callIoDeviceTypePort] = CallAudioStreamServer.getServer(skype).ListeningPort.ToString();
            return true;
        }

        public void finish() {
            try {
                call.Finish();
            }
            catch(Exception) {}
        }

        private void waitingForAnswerThreadProc(object responseSemaphore) {
            try {
                HashSet <TCallStatus> resolvedStatuses = 
                    new HashSet <TCallStatus> {TCallStatus.clsUnplaced, TCallStatus.clsUnknown, TCallStatus.clsRouting, TCallStatus.clsRinging};
                while(resolvedStatuses.Contains(call.Status)) {
                    Thread.Sleep(100);
                }
                ((Semaphore)responseSemaphore).Release();
            }
            catch(Exception) {}
        }

        private void callStatusChangedEvent(ICall iCall, TCallStatus newStatus) {
            if (iCall.Id != this.call.Id)
                return;
            logger.Info("Status changed (ID = " + iCall.Id + "): " + newStatus);
        }
    }
}
