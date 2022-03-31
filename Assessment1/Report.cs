using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{   
    class Report
    {
        public void Output(List<int> analysedText)
        {
            Console.WriteLine("The number of sentences is: " + analysedText[0]);
            Console.WriteLine("The number of vowels is: " + analysedText[1]);
            Console.WriteLine("The number of consonants is: " + analysedText[2]);
            Console.WriteLine("The number of uppercase letters is: " + analysedText[3]);
            Console.WriteLine("The number of lower case letters is: " + analysedText[4]);
        }
    }
}
