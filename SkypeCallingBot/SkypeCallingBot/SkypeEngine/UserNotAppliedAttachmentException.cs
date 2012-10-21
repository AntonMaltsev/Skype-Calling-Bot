using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkypeCallingBot.SkypeEngine {
    public class UserNotAppliedAttachmentException : Exception {
        public UserNotAppliedAttachmentException()
            : base("User has not applied application attachment")
        { }
    }
}
