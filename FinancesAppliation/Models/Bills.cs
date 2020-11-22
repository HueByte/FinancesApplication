using System;
using System.Collections.Generic;
using System.Text;

namespace FinancesAppDLL.Models
{
    public class Bills
    {
        public int id { get; set; }
        public decimal money { get; set; }
        public DateTime buydate { get; set; }
        public DateTime createdate { get; set; }

        public int PersonId { get; set; }
        public People Person { get; set; }

        public int ShopsId { get; set; }
        public Shops Shops { get; set; }
    }
}
