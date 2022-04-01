using System;
using System.Collections.Generic;


namespace InventoryLibrary
{

    class BaseClass
    {
        private string id;
        private float date_created;
        private float date_updated;

        public BaseClass(string id = null, float date_created = default(Datetime), float date_updated =  default(Datetime))
        {
            if (id != null)
                this.id = id;
            else
                this.id = Guid.NewGuid().ToString();

            if (date_created != default(DateTime))
                this.date_created = date_created;
            else
                this.date_created = DateTime.Now;
        
            if (date_updated != default(DateTime))
                this.date_updated = date_updated;
            else
                this.date_updated = DateTime.Now;
        }
    }
}
