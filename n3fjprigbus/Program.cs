using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using n3fjprigbus.n3fjp;
using OmniRigBus.UdpNetwork;

namespace n3fjprigbus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NetworkThreadRunner.GetInstance();
            var netThread = NetworkThread.GetInstance();
            netThread.StartInfoThread();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
