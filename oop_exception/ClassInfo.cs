using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exception
{
    class ClassInfo : System.Attribute
    {
        public string Name;
        public ClassInfo (string Name)
        {
            this.Name = Name;
        }
    }
}
