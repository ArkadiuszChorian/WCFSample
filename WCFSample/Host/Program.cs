using System;
using System.ServiceModel;
using Service;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(Service1));
                host.Open();
                Console.WriteLine("Hit any key to shut down");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Hit any key to exit");
                Console.ReadKey();
            }
        }
    }
}
