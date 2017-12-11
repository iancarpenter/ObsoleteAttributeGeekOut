using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsoleteAttributeGeekOut
{
    class Foo
    {
        [Obsolete]
        public void OldBar()
        {
            Console.WriteLine("Calling OldBar");
        }

        public void NewBar()
        {
            Console.WriteLine("Calling NewBar");
        }
    }
}
