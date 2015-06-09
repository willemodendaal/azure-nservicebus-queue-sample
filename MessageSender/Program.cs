using Messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSender
{
    class Program
    {
        static IBus bus;

        static void Main(string[] args)
        {
            Console.WriteLine("SENDER");
            Console.WriteLine("Press any key to send message to the bus (or Esc to exit)...");

            InitBus();

            var key = Console.ReadKey(true);

            while (key.Key != ConsoleKey.Escape)
            {
                Random r = new Random();
                SendMessage(r.Next(1000));

                key = Console.ReadKey(true);
            }

            Console.WriteLine("Done.");
        }

        private static void SendMessage(int messageId)
        {
            TheRequest request = new TheRequest()
            {
                Body = "msg" + messageId
            };

            bus.Send(request);
        }

        private static void InitBus()
        {
            BusConfiguration busConfiguration = new BusConfiguration();
            busConfiguration.UseTransport<AzureServiceBusTransport>();
            busConfiguration.UsePersistence<InMemoryPersistence>();
            
            bus = NServiceBus.Bus.Create(busConfiguration).Start();
        }
    }
}
