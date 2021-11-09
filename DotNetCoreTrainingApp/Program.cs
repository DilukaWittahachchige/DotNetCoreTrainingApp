﻿// Import components to use in the file
using BLL;
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

            Console.WriteLine(data);
        }
    }





    /* Comments
       can also
       span several lines */
}
