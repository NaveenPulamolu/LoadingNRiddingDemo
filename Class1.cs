using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoadnRidding
{
    class Class1
    {
        public void add()
        {
            int i = 10;
            int j = 20;
            int k = i + j;
            Console.WriteLine("The Sum is {0}", k);
        }
        public void add(int x, int y)
        {
            int a,b,c;
            a = x;
            b = y;
            c = a + b;
            Console.WriteLine("The Sum is {0}", c);
        }
        public virtual void multiply()
        {
            int i, j, k;
            i = 12;
            j = 13;
            k = i * j;
            Console.WriteLine("The Product is from base class {0}", k);

        }
    }
}
