using System;
using System.Collections.Generic;
using System.Text;

namespace ZenithUI.Helper
{

    public class PropertyStore : LunaSoft.CommonObjects.Collections.Generic.Dictionary<object, object>
    {

        protected override void OnInserted(int index, LunaSoft.CommonObjects.Collections.Generic.KeyValuePair<object, object> Item)
        {
            base.OnInserted(index, Item);

            // hERRR..

        }

        public object Parent { get; private set; }

        public PropertyStore(object parent)
        {
            this.Parent = parent;
        }
    }
}
