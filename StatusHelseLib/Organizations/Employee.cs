using StatusHelseLib.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Organizations
{
    public class Employee
    {
        public int Id { get; set; }
        public HealthProfessional Professional { get; set; }
        public Organization Employer { get; }

        internal Employee(Organization employer, HealthProfessional professional) => throw new NotImplementedException();
    }
}
