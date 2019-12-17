using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Organizations
{
    public class OrganizationType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OrganizationType(string name) => throw new NotImplementedException();

        public static OrganizationType ById(int id) => throw new NotImplementedException();
        public void PushUpdate() => throw new NotImplementedException();
    }
}
