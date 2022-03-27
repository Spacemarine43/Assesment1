using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Input
    {
        //Handles the text input for Assessment 1
        string text;

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            bool valid_input = false;
            while (valid_input == false)
            {
                text = Console.ReadLine();
                foreach (char c in text)
                {
                    if (c == '*')
                    {
                        valid_input = true; 
                    }
                }
                if (valid_input)
                {
                    break;
                }
                Console.WriteLine("invalid input");
                
            }
            text = text.Split('*')[0];
            return text;

        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            List<string> textarray = new List<string>(File.ReadAllLines(fileName));

            return textarray.ToString();
        }
    }
}
