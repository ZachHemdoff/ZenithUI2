using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithUI.Forms
{
    public class Grip
#if _FORM_
        : System.Windows.Forms.Control
#endif
    {
        protected Grip()
        {
            // 
        }

        public ZenithUI.Helper.PropertyStore PropertyStore { get; }
    }
}
