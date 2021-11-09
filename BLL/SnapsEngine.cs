using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //static - 
    public static class SnapsEngine
    {
        //access type - public -> can access anywhere
        public static string LoadData()
        {
            int a = 1; //int -> variable type | a -> variable name | 1 -> variable value
            string text = "abcdef";
            int b = a * 2; // result of an operation can be assigned to a variable
            int c; // value of c is intiialized at 0

            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3; //Decimals have much higher precision -financial applications
       
            var d = 5.2; // type is infered

            string text2 = text + " jklm"; // this is a string concatenation

            return $"Final string : {text2} {d} {b} {a} {text}  {flt}, {dbl}, {dcm}";   //string interpolation |This feature is available starting with C# 6.

            ////Similar method for string interpolation
            //string primes;
            //primes = String.Format("Prime numbers less than 10: {0}, {1}, {2}, {3}",
            // 2, 3, 5, 7);
            //Console.WriteLine(primes);
            //// The example displays the following output:
            ////      Prime numbers less than 10: 2, 3, 5, 7

            //-----------------------------------------------------------------------------------------------
            //Types 

            /*The basic types in .NET are:
            byte: integer from 0 to 255
            short / int / long: integer values of different sizes

            float - 7 digits (32 bit) / double 15-16 digits (64 bit): simple / double precision number | Floating binary point types are much faster to work with than decimals.
            For values which are more artefacts of nature which can't 
             really be measured exactly anyway, float/double are more appropriate. For example, scientific data 

            decimal: 28-29 significant digits (128 bit) ,decimal value, suited for acurate computations |. This is usually suitable for any concepts invented by humans:
            financial values are the most obvious example, but there are others too

            char: a character
            string: several characters
            bool: a boolean value(true or false)*/

        }

   
    }
}
