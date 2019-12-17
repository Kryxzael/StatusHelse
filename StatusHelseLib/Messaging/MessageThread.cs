using StatusHelseLib.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Messaging
{
    public class MessageThread
    {
        public User Sender { get; }
        public User Receiver { get; }

        public IOrderedEnumerable<Message> Messages { get; }
    }
}
