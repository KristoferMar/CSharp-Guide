using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Constructor
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            // We want to initianlize a list of objects in our constructor always
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this() // This calls the first constructor to create the empty list of Orders
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) //This referes to the second to set the ID for the cosntructor which also has the list
        {
            this.Name = name;
        }
    }
}
