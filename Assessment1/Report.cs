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
            Console.WriteLine("The number of sentences is: " + analysedText[0]);//utputs number of sentences
            Console.WriteLine("The number of vowels is: " + analysedText[1]);//Outputs number of vowels
            Console.WriteLine("The number of consonants is: " + analysedText[2]);//Outputs number of consonants
            Console.WriteLine("The number of uppercase letters is: " + analysedText[3]);
            Console.WriteLine("The number of lower case letters is: " + analysedText[4]);
        }
    }
}
