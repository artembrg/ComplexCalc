using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalc
{
    //абстрактный класс мнимых чисел с подключенным интерфейсом IFunctions
    abstract class Imaginary: IFunctions
    {
        protected double im;
        public abstract Complex Cosine(Complex a);
        public abstract Complex Exponent(Complex a);
        public abstract Complex Sine(Complex a);
    }
}
