using StatusHelseLib.Organizations;
using StatusHelseLib.Users;
using StatusHelseLib.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Appointments.Requests
{
    internal class OrderRequest
    {
        public Patient Sender { get; set; }
        public HealthService Service { get; set; }

        [Nullable]
        public RichText Notice { get; set; }

        [Nullable]
        public Employee RequestedProfessional { get; }
    }
}
