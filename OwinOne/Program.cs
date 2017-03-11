using Owin;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinOne
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:8089"))
            {
                Console.WriteLine("Server started...");
                Console.Read();
            }
        }
    }

    class Startup
    {
        public void Configuration(IAppBuilder App)
        {
            //App.Run( ctx =>
            //{
            //    return ctx.Response.WriteAsync("Hello World");
            //});
        }
    }
}
