using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Casting
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = b;
            Console.WriteLine(a is A); // True
            Console.WriteLine(a is B); // True
            A aa = new A();
            Console.WriteLine(aa is A); // True
            Console.WriteLine(aa is B); // False

            B b1 = new B();
            A a1 = b1;
            B? b2 = a1 as B;
            Console.WriteLine(b2 is null); // False
            A a2 = new A();
            B? b3 = a2 as B;
            Console.WriteLine(b3 is null); // True

            A aaa = new A();
            B bbb = new B();
            C ccc = new C();
            A t = bbb; B s = (B)t;
            A tt = bbb;
            object ttt = aaa;
            A tttt = aaa; B ss = (B)tttt; //invalid
            A ttttt = ccc;
        }
    }
    public class A
    { }
    public class B : A
    { }
    public class C : B 
    { }
}
