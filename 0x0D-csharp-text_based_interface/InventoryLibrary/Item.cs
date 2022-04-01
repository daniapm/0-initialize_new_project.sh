using System;
using System.Collections.Generic;


namespace InventoryLibrary
{

    class Item : BaseClass
    {
        private string name;
        private string description;
        private float price;
        public List<String> tags;

        public BaseClass(string name = "name", string description = "Description", float price =  0.0f, List<String> tags = "tags")
        {
            this.name = name;
		    this.description = description;
		    this.price = Math.Round(price, 2);
            this.tags = tags;
        }
    }
}
