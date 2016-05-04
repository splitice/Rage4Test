using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Heijden.DNS;

namespace Rage4Test
{
    class Program
    {
        static void Main(string[] args)
        {
            String nameserver = "ns1.r4ns.com";
            String domainFormat = args[0];
            int testCount = 10000;

            Resolver r = new Resolver(Dns.GetHostAddresses(nameserver)[0], 53);
            r.UseCache = false;
            for (int i = 0; i < testCount; i++)
            {
                Console.WriteLine("Performing request {0}", i);
                r.GetHostByName(String.Format(domainFormat, i));
                Thread.Sleep(50);
            }
        }
    }
}
