using System;
using System.Threading;
using SKYPE4COMLib;

namespace SkypeEngine {
    public class SkypeProxy {
        private Skype skype = null;

        public SkypeProxy(int timeOutInSeconds) {
            try {
                skype = new Skype();
            }
            catch(Exception) {
                throw new SkypeServerException();
            }
            Semaphore attachmentSemaphore = new Semaphore(0, 1);
            Thread waitingThread = new Thread(new ParameterizedThreadStart(attachmentWaitingThreadProc));
            waitingThread.IsBackground = true;
            waitingThread.Start(attachmentSemaphore);
            bool attachmentOk = attachmentSemaphore.WaitOne(1000 * timeOutInSeconds);
            if(! attachmentOk) {
                throw new UserNotAppliedAttachmentException();
            }
            else if(skype.Client.IsRunning == false)
                skype.Client.Start(false);
        }

        public CallProxy callTo(string target) {
            return new CallProxy(skype, skype.PlaceCall(target));
        }

        private void attachmentWaitingThreadProc(object attachmentSemaphore) {
            try {
                skype.Attach();
                ((Semaphore)attachmentSemaphore).Release();
            } 
            catch(Exception) {}
        }
    }
}
