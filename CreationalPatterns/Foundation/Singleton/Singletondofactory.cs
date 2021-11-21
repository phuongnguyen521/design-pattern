using System;
using System.Collections.Generic;
using System.Linq;

namespace CreationalPatterns.Foundation.Singleton
{
    //https://www.dofactory.com/net/singleton-design-pattern
    class Singletondofactory
    {
        static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
                Console.WriteLine("Same instance");
            for (int number = 0; number < 15; number++)
            {
                string server = b1.server;
                Console.WriteLine($"Dispatch Request to: {server}");
            }
            Console.ReadKey();
        }
    }

    public class LoadBalancer
    {
        private static LoadBalancer instance;
        List<String> servers = new List<string>();
        Random random = new Random();

        //Lock synchronization object
        private static object locker = new object();
        protected LoadBalancer()
        {
            servers.Add("Server I");
            servers.Add("Server II");
            servers.Add("Server III");
            servers.Add("Server IV");
            servers.Add("Server V");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (instance == null){
                lock (locker)
                {
                    if (instance == null)
                        instance = new LoadBalancer();
                }
            }
            return instance;
        }

        public string server
        {
            get
            {
                int r = random.Next(servers.Count());
                return servers[r].ToString();
            }
        }
    }
}
