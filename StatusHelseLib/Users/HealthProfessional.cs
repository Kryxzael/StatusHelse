using StatusHelseLib.Organizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Users
{
    /// <summary>
    /// Represents a HP user
    /// </summary>
    public class HealthProfessional : User
    {
        public IEnumerable<Employee> Employments { get; }
    }
}
