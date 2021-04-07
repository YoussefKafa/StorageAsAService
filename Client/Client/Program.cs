using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using General;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel httpChannel = new HttpChannel();
            ChannelServices.RegisterChannel(httpChannel, false);
            ICustomerManager proxy = (ICustomerManager)Activator.GetObject(typeof(ICustomerManager), "http://localhost:5000/MyService.soap");
            Console.WriteLine("proxy is ready to use");
            //proxy.findAll();
            Console.ReadKey();
        }
    }
}
