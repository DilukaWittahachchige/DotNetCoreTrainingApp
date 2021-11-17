using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.FileSamples
{
    public static class FileOperation
    {
        #region Directory
        public static void LoadFilePath()
        {
            // Check a folder exists
            string path = "C:/Users/diluk/OneDrive/Desktop/Test";
            Console.WriteLine("Directory {0} exists: {1}", path, Directory.Exists(path));
            // Get a folder's content
            string[] subdirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            Console.WriteLine("There are {0} subdirectories and {1} files in the {2} Directory.", subdirs.Length, files.Length, path);
            // Get the folder from which the program has been run
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("This program runs in the {0} directory", currentDirectory);
        }
        #endregion

        #region Create File
        public static void CreateFile()
        {
            string path = "C:/Users/diluk/OneDrive/Desktop/Test/Test.txt";
            Console.WriteLine("File {0} exists {1}", path, File.Exists(path));
            // Delete a file
            File.Delete(path);
            // Create a file
            File.Create(path).Close();
        }
        #endregion

        #region Read File
        public static byte[] ReadFile()
        {
            string path = "C:/Users/diluk/OneDrive/Desktop/Test/TestRead.txt";
            byte[] buffer = new byte[38];
            FileStream fileStream = File.OpenRead(path);
            fileStream.Read(buffer, 0, 38); // Read first 38 bytes
            return buffer;
        }
        #endregion

        #region Write File
        public static void WriteFile(byte[] fileData)
        {
            string path = "C:/Users/diluk/OneDrive/Desktop/Test/TestWrite.txt";
            FileStream fileStream = File.OpenWrite(path);
            fileStream.Write(fileData, 0, fileData.Length);
            fileStream.Close();
        }
        #endregion

        #region StreamReader and StreamWriter 

        public static void LoadFileInfo()
        {
            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
           
            /*
             Write each directory name to a file. 

             A good practice is to use these objects in a using statement so that the unmanaged resources are correctly disposed.
            The using statement automatically calls Dispose on the object when the code that is using it has completed.*/

            using (StreamWriter sw = new StreamWriter("C:/Users/diluk/OneDrive/Desktop/Test/TestWrite.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("C:/Users/diluk/OneDrive/Desktop/Test/TestRead.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        #endregion
    }
}
