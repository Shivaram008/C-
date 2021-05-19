using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class Four : AccessDemo.Program
    {
        static void Main(string[] args)
        {
            Four p = new Four();
            p.ProtectedMethod();p.ProtectedInternalMethod(); p.PublicMethod();
        }
    }
}
