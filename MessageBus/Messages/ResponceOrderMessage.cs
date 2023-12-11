using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServices.Shared.MessageBus.Messages
{
    public class ResponceOrderMessage
    {
        public Guid OrderId { get; set; }
        public string State { get; set; }
    }
}
