using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusHelseLib.Util
{
    public struct PersonalNumber
    {
        private string _personalNoString;

        public PersonalNumber(string number) : this(long.Parse(number)) => throw new NotImplementedException();
        public PersonalNumber(long no) => throw new NotImplementedException();

        public override string ToString() => throw new NotImplementedException();
        public long ToLong() => throw new NotImplementedException();

        public static bool operator ==(PersonalNumber left, PersonalNumber right) => throw new NotImplementedException();
        public static bool operator !=(PersonalNumber left, PersonalNumber right) => throw new NotImplementedException();

        public override bool Equals(object obj) => throw new NotImplementedException();
        public override int GetHashCode() => throw new NotImplementedException();
    }
}
