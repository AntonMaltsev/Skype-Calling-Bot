using System;
using System.Threading;
using log4net;
using SKYPE4COMLib;

namespace SkypeCallingBot.SkypeEngine {
    public class SkypeProxy {
        private static ILog logger = LogManager.GetLogger("SkypeProxy");
        private Skype skype = null;

        public SkypeProxy(int timeOutInSeconds) {
            try {
                skype = new Skype();
            }
            catch(Exception) {
                throw new SkypeServerException();
            }
            logger.Info("Skype instance created successfully.");
            Semaphore attachmentSemaphore = new Semaphore(0, 1);
            Thread waitingThread = new Thread(new ParameterizedThreadStart(attachmentWaitingThreadProc));
            waitingThread.IsBackground = true;
            waitingThread.Start(attachmentSemaphore);
            bool attachmentOk = attachmentSemaphore.WaitOne(1000 * timeOutInSeconds);
            if(! attachmentOk) {
                logger.Info("Can't attach to Skype (user applying timeout)");
                throw new UserNotAppliedAttachmentException();
            }
            else if(skype.Client.IsRunning == false)
                skype.Client.Start(false);
            logger.Info("Attached to Skype successfully");
        }

        public CallProxy callTo(string target) {
            logger.Info("Call to " + target);
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
