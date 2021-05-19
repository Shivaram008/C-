using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo
{
    public class Program
    {
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected internal Method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();

        }
    }
}
