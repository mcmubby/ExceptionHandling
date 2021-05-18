using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception is unforeseen error when your program is executing
            //Cons of not handling exception
            //Your users get to see the error messages which is not intuitive
            //The error messages contain valuable information that maybe useful to hackers
            //Some lines of the code will be skipped.
            try
            {
                StreamReader streamReader = new StreamReader("sample.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
