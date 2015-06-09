using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using Messages;

namespace Receiver
{
    public class HandleTheRequest : IHandleMessages<TheRequest>
    {
        public void Handle(TheRequest message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Handling message: "+ message.Body);
            Console.ResetColor();
        }

        
    }
}
