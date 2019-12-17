using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Organizations
{
    public class HealthService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Organization Organization { get; set; }
        public bool MayRequestEmployee { get; set; }
        public IEnumerable<Employee> QualifiedEmployees { get; }

        public void AddQualifiedEmployees(Employee employee) => throw new NotImplementedException();
        public void RemoveQualifiedEmployees(Employee employee) => throw new NotImplementedException();

        public static HealthService ById(int id) => throw new NotImplementedException();
        public void PushUpdate() => throw new NotImplementedException();
    }
}
