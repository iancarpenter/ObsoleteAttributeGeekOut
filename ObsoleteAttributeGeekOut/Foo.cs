using System;

namespace ObsoleteAttributeGeekOut
{
    class Foo
    {
        [Obsolete(message:"Use NewBar() instead")]
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
