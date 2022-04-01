using System;
using System.Collections.Generic;


namespace InventoryLibrary
{

    class JSONStorage
    {
        public Dictionary<ClassName> objects;

        public BaseClass(string name = "name"; string description = "Description", float price =  0.0f, List<String> tags = "tags")
        {
            this.name = name;
		    this.description = description;
		    this.price = Math.Round(price, 2);
            this.tags = tags;
        }
    }
}
