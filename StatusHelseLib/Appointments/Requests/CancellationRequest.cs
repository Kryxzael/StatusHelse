using StatusHelseLib.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Appointments.Requests
{
    internal class CancellationRequest
    {
        public CancellationType Type { get; set; }
        public RichText Notice { get; set; }

        public enum CancellationType
        {
            Cancel,
            Postpone
        }
    }
}
