using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoadnRidding
{
    class Class2 : Class1
    {
        public override void multiply()
        {
            int i, j, k;
            i = 20;
            j = 30;
            k = i * j;
            Console.WriteLine("The Product is from child class {0}", k);
        }
    }
}
