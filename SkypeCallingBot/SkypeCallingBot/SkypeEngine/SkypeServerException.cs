using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkypeEngine {
    public class SkypeServerException: Exception {
        public SkypeServerException()
                : base("Problems with Skype server connection occurred") {
        }
    }
}
