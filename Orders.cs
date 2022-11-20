using System;
using System.Collections.Generic;
using System.Text;

namespace Module9
{
    class Orders
    {
        public Orders(string n, string d, string t)
        {
            OrderName = n;
            OrderDesign = d;
            OrderDecoration = t;
        }
        public string OrderName { get; set; }
        public string OrderDesign { get; set; }
        public string OrderDecoration { get; set; }
    }
