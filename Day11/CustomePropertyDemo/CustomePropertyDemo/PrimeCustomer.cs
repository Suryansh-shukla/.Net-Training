using System;
using System.Collections.Generic;
using System.Text;

namespace CustomePropertyDemo
{
    class PrimeCustomer:Customer
    {
        public List<Orders> MyPrimeOrders
        {
            set
            {
                MyOrders = value;
            }
        }
    }
}
