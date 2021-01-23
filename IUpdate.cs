using System;
using System.Collections.Generic;
using System.Text;

namespace SelfUpdate
{
   


    public interface IUpdate
    {
        public bool DownloadUpdate(UpdateContext context);

        public bool BeforeUpdte(UpdateContext context);


        public bool Replace(UpdateContext context);


        public bool FinishUpdate(UpdateContext context);
    }
}
