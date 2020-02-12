using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalc
{
    interface IFunctions
    {
        Complex Cosine(Complex a);
        Complex Sine(Complex a);
        Complex Exponent(Complex a);
    }
}
