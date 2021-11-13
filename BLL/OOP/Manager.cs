
using System;

namespace BLL.OOP
{
    public class Date
    {
        //C# properties are special methods called accessors
        private int _month = 7;  // Backing store | private the name field

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

    class MyClient
    {
        public void Display()
        {
            Date mc = new Date();
            mc.Month = 10;
            int xVal = mc.Month;
            Console.WriteLine(xVal);//Displays 10  
        }
    }

}
