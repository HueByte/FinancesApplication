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
        private IServiceProvider _serviceProvider;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //Create ServiceCollection with DbContext
            var services = new ServiceCollection()
                .AddDbContext<BillContext>();

            //Configure Services
            ConfigureServices(services);

            //Build service provider
            _serviceProvider = services.BuildServiceProvider();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //Add services
            services.AddSingleton<IMonthSum, MonthSum>();
        }
    }
}
