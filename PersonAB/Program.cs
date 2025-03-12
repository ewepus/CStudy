using A.B;
using A.C;
using System;

var nameA = Console.ReadLine();
var nameB = Console.ReadLine();

var pa = new PersonA() { Name = nameA };
var pb = new PersonB() { Name = nameB };

Console.WriteLine(pa.Name);
Console.WriteLine(pb.Name);

namespace A.C
{
    class PersonA
    {
        public string Name { get; set; }
    }
}

namespace A.B
{
    class PersonB
    {
        public string Name { get; set; }
    }
}