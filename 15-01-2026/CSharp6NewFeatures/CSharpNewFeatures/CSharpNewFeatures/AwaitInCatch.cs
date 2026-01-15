using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
namespace CSharpNewFeatures
{

    public class Awaitincatchandfinally
    {
        public static void Main(string[] args)
        {
            FileRead fr = new FileRead();
            WriteLine(" Class Object Created Successfully!\n");
            fr.FileReadOperation();
            WriteLine(" Sample Created for Demo!\n");
            ReadKey();
        }
    }
    public class FileRead
    {
        public async void FileReadOperation()
        {
            try
            {

                StreamReader sr = File.OpenText(@"D:\Sample_File1.txt");
                Thread.Sleep(1000);//1 Second Delay
                WriteLine($"The first line of the file is: {sr.ReadLine()}");
                WriteLine($"The content of file is printed below :-\n============================================\n{sr.ReadToEnd()}");
                sr.Close();
            }
            catch 
            {
                Thread.Sleep(1000);
                 FileNotFound(); 
            }
            finally
            {
                Thread.Sleep(1000);
                await ExitProgram();
            }
        }

        private async Task FileNotFound()
        {
            WriteLine(" File not found. Please check the file name and file location.");
        }

        private async Task ExitProgram()
        {
            WriteLine("\n Press any key to exit");
        }
    }

}
