
using System;

namespace BLL.OOP
{
    public class Date
    {
        //C# properties are special methods called accessors
        private int _month = 7;  // Backing store | private the name field

        // add an instance variable for the object ID
        private int id;

        public static readonly int weight = 450;//Class variables are marked with the static keyword.

        //second part consists of a get accessor and a set accessor
        public int Month // // the Month property
        {
            get => _month;
            //get
            //{
            //    return _month;
            //}
            set
            {
                //Encapsulation
                //Define logic 
                if ((value > 0) && (value < 13))
                {
                    _month = value;
                }
            }
        }

        //private string _name;  // the name field
        //public string Name    // the Name property
        //{
        //    get => _name;
        //    set => _name = value;
        //}
    }

    public class MyClient
    {
        public void Display()
        {
            Date mc = new Date();
            mc.Month = 10;
            int xVal = mc.Month;
            Console.WriteLine(xVal);//Displays 10  
        }
    }

    //base class
    public abstract class Employer
    {
        #region abstract method
        public abstract string LoadEmpCode(string deptCode);
        #endregion

        #region Method Overloading
        //
        public virtual string LoadCodeName()
        {
            string name = "123";
            return $" Code : {name}";
        }

        public virtual string LoadCodeName(string name)
        {
            return $" Code : {name}";
        }

        public virtual string LoadCodeName(string name , string deptName)
        {
            return $" Code : {name}-{deptName}";
        }
        #endregion
    }

    #region inheritance 
    //derived class [child class]
    public class Manager : Employer
    {
        #region Method Overriding
        /*Run Time Polymorphism or Dynamic Polymorphism
        and sometime it is called Late Binding. */

        public override string LoadEmpCode(string deptCode)
        {
            return "1234U";
        }
        #endregion

        public virtual string LoadManagerName()
        {
            string name = "Robert";
            return $" Name : {name}";
        }
    }

    //Inheritance
    public class Coordinator : Manager
    {
        
    }

    public class Officer : Manager
    {
        public override string LoadManagerName()
        {
            string name = "Robert";
            return $" My Manger Name is : {name}";
        }
    }

    /* Points to be remembered,
         Method cannot be private.
         Only abstract or virtual method can be overridden.
         Which method should be called is decided at run time. */
    #endregion

    #region Inheritance and constructor
    /*When using inheritance, the constructor of the base class must be called first.
    If the parent class has a default constructor, then this is not required. */
    public class Feline
    {
        private string name;
        public Feline(string name) { this.name = name; }
    }
    public class Cat : Feline
    {
        public Cat(string name) : base(name) { }
    }
    #endregion
}
