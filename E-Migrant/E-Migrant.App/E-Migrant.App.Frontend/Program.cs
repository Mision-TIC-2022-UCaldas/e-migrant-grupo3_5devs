using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace E_Migrant.App.Frontend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

//dotnet ef migrations add IdentityInitial --context IdentityDataContext
//dotnet ef database update --context IdentityDataContext
//dotnet ef migrations add Entidades --startup-project ..\E-Migrant.App.Frontend\ --context appContext
//dotnet ef database update --startup-project ..\E-Migrant.App.Frontend\ --context appContext
//dotnet new page -n PanelControlEntidad -na E-Migrant.App.Frontend.Pages -o .\Pages\WebEntidad\Usuario