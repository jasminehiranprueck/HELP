using System;
using System.Collections.Generic;
using System.Text;

namespace Module9
{
    class Design
    {
        public Design(string line)
        {
            var split = line.Split(',');
            DesignID = Convert.ToInt32(split[0]);
            DesignName = split[1];
        }

        public int DesignID { get; set; }
        public string DesignName { get; set; }
    }
}
