// Import components to use in the file
using BLL;
using BLL.DataStructures;
using BLL.Delegates;
using BLL.OOP;
using BLL.StringOperation;
using System;
//Extension Reference
using BLL.Extensions;


// A namespace is a logical grouping of components
namespace DotNetCoreTrainingApp
{
    // A class is a kind of component
    class Program
    {
        // The Main method is the entrypoint of an application
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!"); // Instructions separated by ";"

            //var data = SnapsEngine.LoadData();

            DataStructure dataStructures = new DataStructure();
            //string[] strArray = dataStructures.LoadArrayDataFirst();
            //string[] styArraySecond = dataStructures.LoadArrayDataSecond();
            //array is accessed through its index
            //Console.WriteLine($"{strArray[0]} {strArray[1]}");
            //Nothing display for index 1
            //Console.WriteLine($"{styArraySecond[0]} {styArraySecond[1]}");

            //List
            //dataStructures.LoadNameList();

            //Dictionary
            //dataStructures.LoadAgeDict();

            //switch condition
            //dataStructures.LoadResponse("eco");

            //Hashtable
            //dataStructures.LoadHashtable();

            //Coordinate point = new Coordinate(10, 20);
            //Console.WriteLine(point.x); //output: 10  
            // Console.WriteLine(point.y); //output: 20

            //Enum 
            //dataStructures.LoadValue(Direction.UP);

            //StringOperation stringOpp = new StringOperation();
            //stringOpp.LoadStringData();

            //Console.WriteLine(data);

            //OOP
            //Coordinator coordinator = new Coordinator();
            //var managerName = coordinator.LoadManagerName();
            //Console.WriteLine(managerName);

            //DelegateExample delg = new DelegateExample();
            //delg.ShowData();

            //Call static method
            //string[] values = { "Lorem", "Ipsum" };
            //DelegateExample.Process(values, DelegateExample.ToUpper);

            // Extension method 

            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine(i);

        }
    }





    /* Comments
       can also
       span several lines */
}
