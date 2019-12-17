using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Organizations
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrganizationType Type { get; set; }

        public IEnumerable<Employee> Employees { get; }
        public IEnumerable<HealthService> Services { get; }

        public void AddEmployee() => throw new NotImplementedException();
        public void RemoveEmployee() => throw new NotImplementedException();

        public void AddService() => throw new NotImplementedException();
        public void RemoveService() => throw new NotImplementedException();

        public static Organization ById(int id) => throw new NotImplementedException();
        public void PushUpdate() => throw new NotImplementedException();
    }
}
