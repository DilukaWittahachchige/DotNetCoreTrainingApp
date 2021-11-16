using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Delegates
{
    public class DelegateExample
    {

        //https://www.tutorialspoint.com/csharp/csharp_delegates.htm

        //delegate <return type> <delegate-name> <parameter list>

        //Instantiating Delegates

        #region Delegate with single method
        //create delegate
        public delegate void MyDelegare(string var);
        public void LoadData(object sender, EventArgs e)

        {
            // Assign method to delegate
            //delegate that holds the reference
            MyDelegare objMyDelegare = new MyDelegare(GetData);
            objMyDelegare("Mahesh");
        }
        public void GetData(string Name)
        {
            Console.WriteLine(Name);
        }
        #endregion

        #region Delegate with multiple methods

        public delegate void MyDelegareTwo(string var);
        protected void LoadMultipleDelegates()
        {

            //Refer two methods for same delegate
            MyDelegareTwo objMyDelegare = new MyDelegareTwo(GetDataOne);
            objMyDelegare += new MyDelegareTwo(GetDataTwo);

            //GetDataOne and GetDataTwo is called  
            objMyDelegare("Mahesh");

            //GetDataOne Remove reference from delegate
            objMyDelegare -= new MyDelegareTwo(GetDataOne);


            //GetDataTwo is called  
            objMyDelegare("Mahesh");

        }

        public void GetDataOne(string Name)
        {
            Console.WriteLine("GetDataOne" + Name);
        }

        public void GetDataTwo(string Name)
        {
            Console.WriteLine("GetDataTwo" + Name);
        }

        #endregion

        #region Delegate with multiple instances
        // delegate int NumberChanger(int n);
        //

        //        class TestDelegate
        //        {
        //            static int num = 10;

        //            public static int AddNum(int p)
        //            {
        //                num += p;
        //                return num;
        //            }
        //            public static int MultNum(int q)
        //            {
        //                num *= q;
        //                return num;
        //            }
        //            public static int getNum()
        //            {
        //                return num;
        //            }

        //            static void LoadData()
        //            {
        //                //create delegate instances
        //                NumberChanger nc1 = new NumberChanger(AddNum);
        //                NumberChanger nc2 = new NumberChanger(MultNum);

        //                //calling the methods using the delegate objects
        //                nc1(25);
        //                Console.WriteLine("Value of Num: {0}", getNum());
        //                nc2(5);
        //                Console.WriteLine("Value of Num: {0}", getNum());
        //                Console.ReadKey();
        //            }
        //        }
        //    

        #endregion

        #region Delegate with Lamda expression
        //
        delegate int del(int i);
        public void ShowData()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Console.WriteLine(j);//j = 25
        }

        #endregion

        #region Pass Delegate as method parameter
        public delegate string StringProcessor(string s);

        public static void Process(string[] values, StringProcessor p)
        {
            for (int i = 0; i < values.Length; i++)
            {
                //Invoke method 
                values[i] = p(values[i]);
                Console.WriteLine(values[i]);
            }
        }
        public static string ToUpper(string value)
        {
            return value.ToUpper();
        }

        #endregion
    }
}
