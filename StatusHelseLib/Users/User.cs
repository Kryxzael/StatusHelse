using StatusHelseLib.Appointments;
using StatusHelseLib.Data;
using StatusHelseLib.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Users
{
    /// <summary>
    /// The base class for any user that can log onto the system
    /// </summary>
    public abstract class User
    {
        public PersonalNumber PersonalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AppointmentManager Appointments { get; }

        public static User ById(int id) => throw new NotImplementedException();
        public void PushUpdate() => throw new NotImplementedException();
    }
}
