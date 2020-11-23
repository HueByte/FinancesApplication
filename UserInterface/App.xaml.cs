using FinancesAppDLL.DataAccess;
using FinancesAppDLL.DataManagment;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var services = new ServiceCollection()
                .AddDbContext<BillContext>()
                .AddSingleton<IMonthSum, MonthSum>();
        }
    }
}
