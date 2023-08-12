using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblem
{
    internal class Child
    {
        private readonly ParentA parenta;
        private readonly ParentB parentb;

        public Child()
        {
            parenta = new ParentA();
            parentb = new ParentB();
        }
        public string Name { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void MethodeA()
        {
            Console.WriteLine("child");
        }
       
    }
}
