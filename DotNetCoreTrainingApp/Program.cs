// Import components to use in the file
using BLL;
using BLL.DataStructures;
using BLL.StringOperation;
using System;

// A namespace is a logical grouping of components
namespace DotNetCoreTrainingApp
{
    // A class is a kind of component
    class Program
    {
        // The Main method is the entrypoint of an application
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // Instructions separated by ";"

            var data = SnapsEngine.LoadData();

            DataStructure dataStructures = new DataStructure();
            string[] strArray = dataStructures.LoadArrayDataFirst();
            string[] styArraySecond = dataStructures.LoadArrayDataSecond();
            //array is accessed through its index
            Console.WriteLine($"{strArray[0]} {strArray[1]}");
            //Nothing display for index 1
            Console.WriteLine($"{styArraySecond[0]} {styArraySecond[1]}");

            //List
            dataStructures.LoadNameList();

            //Dictionary
            dataStructures.LoadAgeDict();

            StringOperation stringOpp = new StringOperation();
            stringOpp.LoadStringData();

            Console.WriteLine(data);
        }
    }





    /* Comments
       can also
       span several lines */
}
