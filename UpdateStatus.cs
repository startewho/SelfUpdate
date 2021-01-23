using System;
using System.Collections.Generic;
using System.Text;

namespace SelfUpdate
{
   public enum UpdateStatus
    {
        Init,
        Downloaded,
        BeforeUpdate,
        Replace,
        FinishUpdate,
        Failed,
    }
}
