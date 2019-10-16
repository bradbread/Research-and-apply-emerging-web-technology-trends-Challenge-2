using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeMaker
{
    class LengthLessThanOneException : Exception
    {
        public LengthLessThanOneException(string message) : base(message) { }
    }

    class DecimalPointEception : Exception
    {
        public DecimalPointEception(string message) : base(message) { }
    }
}
