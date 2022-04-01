using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    class C : B
    {
        public object PropertyB { get; set; }

        public C(object a, object b)
            : base(a)
        {
            PropertyB = b;
        }

    }
}
