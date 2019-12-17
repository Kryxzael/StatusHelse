using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Util
{
    public interface IDatabaseObject
    {
        int Id { get; set; }
        void PushUpdate();
    }
}
