using FinancesAppDLL.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancesAppDLL.DataManagment
{
    public class MonthSum : IMonthSum
    {
        private BillContext context;

        public MonthSum(BillContext _context)
        {
            context = _context;
        }

        public decimal monthSum(DateTime month)
        {
            decimal sum=0;
            var billinmonth = context.Bills
                             .Where(s => s.buydate.Month == month.Month)
                              .ToList();
            foreach(var summy in billinmonth)
            {
                sum = sum + summy.money;
            }
            return sum;

        }
    }
}
