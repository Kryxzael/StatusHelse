using StatusHelseLib.Users;
using StatusHelseLib.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Messaging
{
    public class Message
    {
        public User Sender { get; }
        public User Receiver { get; }
        public DateTime TimeSent { get; }
        public string Subject { get; }
        public RichText Content { get; }
    }
}
