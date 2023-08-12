using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    internal class ParentA : SuperParent
    {
        public void MethodA()
        {
            Console.WriteLine("ParentAMethodA");
        }

        public void MethodB()
        {
            Console.WriteLine("ParentAMethodB");
        }
    }
}
