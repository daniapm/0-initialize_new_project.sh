using System;
using System.Collections.Generic;


namespace InventoryLibrary
{

    class User : BaseClass
    {
        private string name;

        public BaseClass(string name = "name")
        {
            this.name = name;
        }
    }
}
