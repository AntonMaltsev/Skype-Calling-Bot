using System;
using System.Collections.Generic;
using System.Threading;
using SKYPE4COMLib;

namespace SkypeEngine {
    public class CallProxy {
        private Call call = null;
        private Skype skype = null;

        public CallProxy(Skype skype, Call call) {
            this.call = call;
            this.skype = skype;
        }

        public bool waitForResponse(int timeOutInSeconds) {
            Semaphore responseSemaphore = new Semaphore(0, 1);
            Thread waitingThread = new Thread(new ParameterizedThreadStart(waitingForResponseThreadProc));
            waitingThread.IsBackground = true;
            waitingThread.Start(responseSemaphore);
            if (! responseSemaphore.WaitOne(timeOutInSeconds * 1000) || call.Status != TCallStatus.clsInProgress)
            {
                try {
                    call.Finish();
                }
                catch(Exception) {}
                return false;
            }
            skype.CallStatus += callStatusChangedEvent;
            return true;
        }

        public void sendToAudioInput(string filePath) {
            
        }

        public void captureSubscriberAudio(string filePath) {

        }

        private void waitingForResponseThreadProc(object responseSemaphore) {
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
            Console.WriteLine("Status changed: " + newStatus);
        }
    }
}
