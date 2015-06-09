using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class TheResponse : IEvent
    {
        public string Body { get; set; }
    }
}
