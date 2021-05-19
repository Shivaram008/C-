using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo
{
    class Three
    {
        public static void Main()
        {
            Program t = new Program();
            t.InternalMethod();t.ProtectedInternalMethod();
            t.PublicMethod();
        }
    }
}
