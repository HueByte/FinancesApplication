using System;
using System.Collections.Generic;
using System.Text;

namespace FinancesAppDLL.Models
{
    public class Bills
    {
        public int id { get; set; }
        public decimal money { get; set; }
        public DateTime butdate { get; set; }
        public DateTime createdate { get; set; }

        public int PersonId { get; set; }
        public People People { get; set; }

        public int ShopsId { get; set; }
        public Shops Shops { get; set; }

    }
    public class People
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Shops
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
