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
        
        string text;// text is used as the variable for storing input

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        
        public string manualTextInput()
        {
            text = Console.ReadLine();//Text input
            text = text.Split('*')[0];// if sentence ends in an * then it tells the porgram that there is where the sentence has ended
            return text;//returns text to the object to be analysed

        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        
        public string fileTextInput(string fileName)
        {
            List<string> textarray = new List<string>(File.ReadAllLines(fileName));//reads all lines in the file to put into a text array

            text = string.Join(",",textarray);// coverts the list of strings into one string
            return text;// returns text of the file to be analysed
        }
    }
}
