using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass2
{
    internal class Hello
    {
        public string SayHello()
        {
            return "Hello Alen";
        }
        public string SayHelloName(string name)
        {
            return $"Hello {name}";
        }
    }
}
