using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Analysis//defines class analysis
    {
        List<char> vowels = new List<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };// list of vowels used for the consonant count and vowel count methods
        List<char> alphabet = new List<char> {'a','b','c','d','e','f','g','h','i','j','k','k','l','m','n', 'o','p','q','r','s','t','u','v','w','x','y','z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };//List of characters to use in almost all analysis methods
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        int letterCount(string input)//Letter count is used so i could use less lines making the consonant count and lower case count methods
        {
            int count = 0;// i use the variable count for all methods it just means if almost all code is the same i can recycle code

            foreach (char x in input)
            {
                foreach(char y in alphabet)
                {
                    if(x == y)//compares every character in input to every value in the list it's inefficient but it works
                    {
                        count += 1;
                    }
                }
            }
            return count;//returns the number of letters in input
        }
        
        int sentenceCount(string input)// sentence count to count the number of sentences in the input
        {
            char CharBefore = ' ';// i use char before to compare instead of the current because if elipsis was used the program would think it's 3 different sentences
            int count = 1;// count starts as 1 because just by having an input one sentence is made

            foreach (char x in input)
            {
                if(CharBefore == '.' && x != '.' || CharBefore == '!' || CharBefore == '?')// compares the char in input with any sentence ending punctuation i could think of
                {
                    count += 1;
                }
                CharBefore = x;// char before becomes the current value for x before x changes to the next char
            }

            return count;//returns the number of sentences in input
        }

        int vowelCount(string input)// method to count number of vowels in input
        {
            int count = 0;

            foreach(char x in input)
            {
                foreach(char y in vowels)// uses the vowel list to check if a char is a vowel
                {
                    if(x == y)
                    {
                        count += 1;
                    }
                }
            }

            return (count);// returns number of vowels in input
        }

        int consonantCount(string input)// method which counts number of consonants in an input
        {

            int NumberOfVowels = vowelCount(input);// uses the vowel count method so i don't have to make a list of consonants
            int NumberOfLetters = letterCount(input);// calls the letter count method so whatever letters is left over from the vowel count is a consonant

            int count = NumberOfLetters - NumberOfVowels;// i used munber of letters instead of chars of the imput because of punctuation and spaces

            return (count);//returns number of consonants in an input

        }

        int UpperCount(string input)// method that counts number of upper case letters
        {
            int count = 0;
            int yIndex = 0;//Y index just means the index of the list of letters

            foreach(char x in input)
            {
                yIndex = 0;// y index is reset to 0

                foreach(char y in alphabet)
                {
                    if(x == y && yIndex > 25)// i can use Y index so all lower case letters in letters are not counted
                    {
                        count += 1;
                    }

                    yIndex += 1;//increment on Y index so it follows char y on the list
                }
            }

            return count;//returns number of upper case letters
        }

        int LowerCount(string input)//method for counting number of lower case letters
        {

            int NumberOfLetters = letterCount(input);//similar to the consonant count i chose to use methods i already had to get the count to save development time
            int NumberOfUpperLetters = UpperCount(input);

            int count = NumberOfLetters - NumberOfUpperLetters;

            return count;//returns number of lower case letters
        }
        public List<int> analyseText(string input)//main method which puts all values of the count in each method into a list
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            
            List<int> values = new List<int>();//makes a list for the count variables to be stored
            //Initialise all the values in the list to '0'
            values.Add(sentenceCount(input));
            values.Add(vowelCount(input));
            values.Add(consonantCount(input));
            values.Add(UpperCount(input));
            values.Add(LowerCount(input));


            return values;// returns the list of values to the object
        }
    }
}
