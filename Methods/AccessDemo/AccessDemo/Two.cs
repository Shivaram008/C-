using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo
{
    class Two : Program
    {
        public static void Main()
        {
            Two c = new Two();
            c.InternalMethod();c.ProtectedMethod();c.ProtectedInternalMethod();c.PublicMethod();
        }
    }
}
