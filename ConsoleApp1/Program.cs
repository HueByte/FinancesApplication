using System;
using FinancesAppDLL.DataAccess;
using FinancesAppDLL.Models;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BillContext())
            {

                var std = new People()
                {
                    id =1,
                    name = "Bill"
                };

                context.People.Add(std);
                context.SaveChanges();
            }
        }
    }
}
