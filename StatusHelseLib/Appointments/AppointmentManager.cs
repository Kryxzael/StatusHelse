using StatusHelseLib.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Appointments
{
    public class AppointmentManager
    {
        public User Owner { get; }

        public AppointmentManager(User owner) => throw new NotImplementedException();

        public IEnumerable<Appointment> GetAppointments() => throw new NotImplementedException();
        public Appointment GetNextAppointment() => throw new NotImplementedException();
        public IEnumerable<Appointment> GetUpcommingAppointments() => throw new NotImplementedException();
        public IEnumerable<Appointment> GetAppointmentsAtDate(DateTime date) => throw new NotImplementedException();
    }
}
