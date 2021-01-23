using System;
using System.Collections.Generic;
using System.Text;

namespace SelfUpdate
{
    public class BaseUpdate : IUpdate
    {
        public bool BeforeUpdte(UpdateContext context)
        {
            throw new NotImplementedException();
        }

        public bool DownloadUpdate(UpdateContext context)
        {
            throw new NotImplementedException();
        }

        public bool FinishUpdate(UpdateContext context)
        {
            throw new NotImplementedException();
        }

        public bool Replace(UpdateContext context)
        {
            throw new NotImplementedException();
        }
    }
}
