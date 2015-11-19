using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                //behavior.HttpGetBinding.SendTimeout = new TimeSpan(5000);
                host.Opened += delegate
                {
                    Console.WriteLine("CalculaorService已经启动，按任意键终止服务！");
                };
                host.Open();
                Console.Read();
            }
        }
    }
}
