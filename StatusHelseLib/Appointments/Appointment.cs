using StatusHelseLib.Organizations;
using StatusHelseLib.Users;
using StatusHelseLib.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Appointments
{
    public class Appointment
    {
        public Patient Patient { get; set; }
        public HealthProfessional HealthProfessional { get; set; }
        public DateTime Time { get; set; }
        public TimeSpan Duration { get; set; }
        public string Title { get; set; }
        public RichText Note { get; set; }
        public HealthService Service { get; set; }

        public DateTime EndTime { get; }

        public void RequestCancelFromPatient(RichText notice = null) => throw new NotImplementedException();
        public void RequestPostponementFromPatient(RichText notice = null) => throw new NotImplementedException();
        public void CancelAppointment() => throw new NotImplementedException();
    }
}
