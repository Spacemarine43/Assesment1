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
            
            Analysis analysis = new Analysis();// creates an object for class Analysis

            Input User_Input = new Input();// create an object for class input
            
            string text = "";// text is the variable which will be storing the input

            try
            {
                Console.WriteLine("enter an option:" + "\n 1) manual input" + "\n 2) file input");//Tells the user to either get a manual input or a file input

                int option = Convert.ToInt32(Console.ReadLine());// user input

                if (option == 1)
                {
                    text = User_Input.manualTextInput();// calls the class Input for the method amnual text input
                    Console.WriteLine(text);
                }
                else if (option == 2)
                {
                    Console.WriteLine("enter a file path");
                    try
                    {
                        string file_path = Console.ReadLine();// user inputs file path for the system to find the file
                        text = User_Input.fileTextInput(file_path);// calls the class Input for the method file text input
                        Console.Writeline(text);
                    }
                    catch(FileNotFoundException e)// catches file not found errors
                    {
                        Console.Writeline("File not found");// lets the user know what the error is
                    }
                }
            }
            catch (Exception e)//catches any exception in the the users input
            {
                Console.WriteLine("error");
            }

            //Pass the text input to the 'analyseText' method

            foreach(int i in analysis.analyseText(text))// calls the analysis class in a for loop for the code to be outputted
            {
                Console.WriteLine(i);//writes the frequency of sentences,vowels,consonants,upper and lower case letters
            }


        }



    }
}
