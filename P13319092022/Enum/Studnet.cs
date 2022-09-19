using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    class Studnet
    {
        public string Name;
        public string SurName;

        public override string ToString()
        {
            return $"Name: {Name}\nSurName: {SurName}";
        }
    }
}
