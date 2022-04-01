using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    class B : A
    {
        public object PropertyA { get; set; }

        public B(object a)
        {
            PropertyA = a;
        }
    }
}
