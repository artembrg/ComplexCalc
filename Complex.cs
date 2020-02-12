using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalc
{
    //класс комплексных чисел
    class Complex : Imaginary
    {
        protected double re; //действительная часть комплексного числа
        protected double mod; //модуль комплексного числа
        protected double angle; //угол комплексного числа

        /// <summary>
        /// Позволяет создать комплексное число по двум параметрам.
        /// </summary>
        /// <param name="re">Задает действительную часть числа</param>
        /// <param name="im">Задает мнимую часть</param>
        public Complex(double re, double im) 
        {
             this.re = re;
             this.im = im;
             mod = Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
             if (re == 0 && im == 0) angle = 0;
             else if (re == 0 && im > 0) angle = 90;
             else if (re == 0 && im < 0) angle = -90;
             else if (re > 0) angle = 360 * Math.Atan2(im, re) / 2 / Math.PI;
             else if (re < 0) angle = 360 * Math.Atan2(im, re) / 2 / Math.PI;
        }
        /// <summary>
        /// Сложение двух комплексных чисел
        /// </summary>
        /// <param name="z1">Слагаемое</param>
        /// <param name="z2">Слагаемое</param>
        /// <returns>Возвращает сумму двух комплексных чисел</returns>
        public static Complex operator +(Complex z1, Complex z2)
        {
            z1.re += z2.re;
            z1.im += z2.im;
            z1.mod = Math.Sqrt(Math.Pow(z1.re, 2) + Math.Pow(z1.im, 2));
            if (z1.re == 0 && z1.im == 0) z1.angle = 0;
            else if (z1.re == 0 && z1.im > 0) z1.angle = 90;
            else if (z1.re == 0 && z1.im < 0) z1.angle = -90;
            else if (z1.re > 0) z1.angle = 360 * Math.Atan2(z1.im, z1.re) / 2 / Math.PI;
            else if (z1.re < 0) z1.angle = 360 * Math.Atan2(z1.im, z1.re) / 2 / Math.PI;
            return z1;
        }
        /// <summary>
        /// Вычитание двух комплексных чисел
        /// </summary>
        /// <param name="z1">Уменьшаемое</param>
        /// <param name="z2">Вычитаемое</param>
        /// <returns>Возвращает разность двух комплексных чисел</returns>
        public static Complex operator -(Complex z1, Complex z2)
        {
            z1.re -= z2.re;
            z1.im -= z2.im;
            z1.mod = Math.Sqrt(Math.Pow(z1.re, 2) + Math.Pow(z1.im, 2));
            if (z1.re == 0 && z1.im == 0) z1.angle = 0;
            else if (z1.re == 0 && z1.im > 0) z1.angle = 90;
            else if (z1.re == 0 && z1.im < 0) z1.angle = -90;
            else if (z1.re > 0) z1.angle = 360 * Math.Atan2(z1.im, z1.re) / 2 / Math.PI;
            else if (z1.re < 0) z1.angle = 360 * Math.Atan2(z1.im, z1.re) / 2 / Math.PI;
            return z1;
        }
        /// <summary>
        /// Умножение двух комплексных чисел
        /// </summary>
        /// <param name="z1">Множитель</param>
        /// <param name="z2">Множитель</param>
        /// <returns>Возвращает произведение двух комплексных чисел</returns>
        public static Complex operator *(Complex z1, Complex z2)
        {
            z1.mod *= z2.mod;
            z1.angle += z2.angle;
            z1.re = z1.mod * Math.Cos(z1.angle * Math.PI * 2 / 360);
            z1.im = z1.mod * Math.Sin(z1.angle * Math.PI * 2 / 360);
            return z1;
        }
        /// <summary>
        /// Деление двух комплексных чисел
        /// </summary>
        /// <param name="z1">Делимое</param>
        /// <param name="z2">Делитель</param>
        /// <returns>Возвращает частное двух комплексных чисел</returns>
        public static Complex operator /(Complex z1, Complex z2)
        {
            if (z2.mod == 0) z1 = null;
            else
            {
                z1.mod /= z2.mod;
                z1.angle -= z2.angle;
                z1.re = z1.mod * Math.Cos(z1.angle * Math.PI * 2 / 360);
                z1.im = z1.mod * Math.Sin(z1.angle * Math.PI * 2 / 360);
            }
            return z1;
        }
        /// <summary>
        /// Косинус комплексного числа
        /// </summary>
        /// <param name="a">Аргумент косинуса</param>
        /// <returns>Возвращает комплексное число, равное косинусу аргумента</returns>
        public override Complex Cosine(Complex a)
        {
            Complex z = new Complex(0, 0);
            z.re = Math.Cos(a.re) * Math.Cosh(a.im);
            z.im = -Math.Sin(a.re) * Math.Sinh(a.im);
            z.mod = Math.Sqrt(Math.Pow(z.re, 2) + Math.Pow(z.im, 2));
            if (z.re == 0 && z.im == 0) z.angle = 0;
            else if (z.re == 0 && z.im > 0) z.angle = 90;
            else if (z.re == 0 && z.im < 0) z.angle = -90;
            else if (z.re > 0) z.angle = 360 * Math.Atan2(z.im, z.re) / 2 / Math.PI;
            else if (z.re < 0) z.angle = 360 * Math.Atan2(z.im, z.re) / 2 / Math.PI;
            return z;
        }
        /// <summary>
        /// Экспонента комплексного числа
        /// </summary>
        /// <param name="a">Аргумент экмпоненты</param>
        /// <returns>Возвращает комплексное число, равное экспоненте аргумента</returns>
        public override Complex Exponent(Complex a)
        {
            Complex z = new Complex(0, 0);
            z.re = Math.Exp(a.re) * Math.Cos(a.im);
            z.im = Math.Exp(a.re) * Math.Sin(a.im);
            z.mod = Math.Sqrt(Math.Pow(z.re, 2) + Math.Pow(z.im, 2));
            if (z.re == 0 && z.im == 0) z.angle = 0;
            else if (z.re == 0 && z.im > 0) z.angle = 90;
            else if (z.re == 0 && z.im < 0) z.angle = -90;
            else if (z.re > 0) z.angle = 360 * Math.Atan2(z.im, z.re) / 2 / Math.PI;
            else if (z.re < 0) z.angle = 360 * Math.Atan2(z.im, z.re) / 2 / Math.PI;
            return z;
        }
        /// <summary>
        /// Синус комплексного числа
        /// </summary>
        /// <param name="a">Аргумент синуса</param>
        /// <returns>Возвращает комплексное число, равное синусу аргумента</returns>
        public override Complex Sine(Complex a)
        {
            Complex z = new Complex(0, 0);
            z.re = Math.Sin(a.re) * Math.Cosh(a.im);
            z.im = Math.Cos(a.re) * Math.Sinh(a.im);
            z.mod = Math.Sqrt(Math.Pow(z.re, 2) + Math.Pow(z.im, 2));
            if (z.re == 0 && z.im == 0) z.angle = 0;
            else if (z.re == 0 && z.im > 0) z.angle = 90;
            else if (z.re == 0 && z.im < 0) z.angle = -90;
            else if (z.re > 0) z.angle = 360 * Math.Atan2(z.im, z.re) / 2 / Math.PI;
            else if (z.re < 0) z.angle = 360 * Math.Atan2(z.im, z.re) / 2 / Math.PI;
            return z;
        }

        public double Re => re;

        public double Im => im;

        public double Mod => mod;

        public double Angle => angle;
    }
}
