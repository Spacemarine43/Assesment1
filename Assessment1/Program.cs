using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            Analysis analysis = new Analysis();

            //Create 'Input' object
            Input User_Input = new Input();
            //Get either manually entered text, or text from a file
            string text = "";

            //Create an 'Analyse' object 
            try
            {
                Console.WriteLine("enter an option:" + "\n 1) manual input" + "\n 2) file input");

                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    text = User_Input.manualTextInput();
                    Console.WriteLine(text);
                }
                else if (option == 2)
                {
                    Console.WriteLine("enter a file path");
                    try
                    {
                        string file_path = Console.ReadLine();
                        text = User_Input.fileTextInput(file_path);
                    }
                    catch(FileNotFoundException e)
                    {
                        Console.Writeline("File not found try again")
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }

            //Pass the text input to the 'analyseText' method

            foreach(int i in analysis.analyseText(text))
            {
                Console.WriteLine(i);
            }
            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }



    }
}
