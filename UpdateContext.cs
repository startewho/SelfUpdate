using System;
using System.Collections.Generic;
using System.Text;

namespace SelfUpdate
{
    public  class UpdateContext
    {
        public string DownloadUrl { get; set; }

        public List<Command> BeforeCmds { get; set; }

        public List<Command> FinishCmds { get; set; }

        public bool RunSelf { get; set; }
    }
}
