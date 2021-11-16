using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Generic
{
    public class GenericSample<T>
    {

        #region generic example
        T _value;

        public GenericSample(T t)
        {
            // The field has the same type as the parameter.
            this._value = t;
        }

        public void Write()
        {
            Console.WriteLine(this._value);
        }
        #endregion

    }

    #region generic type constraints example
    /// <summary>
    /// Requires type parameter that implements interface IDisposable.
    /// </summary>
    /// 
    class Ruby<T> where T : IDisposable
    {
    }

    /// <summary>
    /// Requires type parameter that is a struct.
    /// </summary>
    class Python<T> where T : struct
    {
    }

    /// <summary>
    /// Requires type parameter that is a reference type with a constructor.
    /// </summary>
    class Perl<V> where V : class, new()
    {
    }

    public class GenericConstraint
    {
        // DataTable implements IDisposable so it can be used with Ruby.
        Ruby<DataTable> ruby = new Ruby<DataTable>();

        // Int is a struct (ValueType) so it can be used with Python.
        Python<int> python = new Python<int>();

        // Program is a class with a parameterless constructor (implicit)
        // ... so it can be used with Perl.
        Perl<GenericConstraint> perl = new Perl<GenericConstraint>();
    }
    #endregion

    /*where T : struct  – Type argument must be a value type
      where T : class – Type argument must be a reference type
      where T : new() – Type argument must have a public parameterless constructor.
      where T : <base class> – Type argument must inherit from<base class> class.
      where T : <interface> –  Type argument must implement from<interface> interface.
      where T : U – There are two type arguments T and U.T must be inherit from U.

     static void Swap<T>(ref T input1, ref T input2) where T : struct { }
     static void Swap<T>(ref T input1, ref T input2) where T : class { }
     static void Swap<T>(ref T input1, ref T input2) where T : new() { }
     static void Swap<T>(ref T input1, ref T input2) where T : BaseEmployee { }
     static void Swap<T>(ref T input1, ref T input2) where T : IEmployee { }
     static void Swap<T, U>(ref T input1, ref U input2) where T : U { }
    */
}




