using System;
using System.Collections.Generic;


namespace InventoryLibrary
{

    class Inventory : BaseClass
    {
        public User user_id;
        public Item item_id;
        public int quantity;

        public BaseClass(string user_id = "user_id"; string item_id = "item_id", int quantity =  1)
        {
            if (quantity < 0) {
                quantity = 1
            }
            else {
                this.quantity = quantity;
            }

            if (user_id == null) {
                this.user_id = "user_id"
            }
            else {
                this.user_id = user_id;
            }

            if (item_id == null) {
                this.item_id = "item_id"
            }
            else {
                this.item_id = item_id;
            }
		    
        }
    }
}
