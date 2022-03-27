using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Analysis
    {
        List<char> vowels = new List<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        List<char> alphabet = new List<char> {'a','b','c','d','e','f','g','h','i','j','k','k','l','m','n', 'o','p','q','r','s','t','u','v','w','x','y','z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        int letterCount(string input)
        {
            int count = 0;

            foreach (char x in input)
            {
                foreach(char y in alphabet)
                {
                    if(x == y)
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
        int sentenceCount(string input)
        {
            char CharBefore = ' ';
            int count = 1;

            foreach (char x in input)
            {
                if(CharBefore == '.' && x != '.' || CharBefore == '!' || CharBefore == '?')
                {
                    count += 1;
                }
                CharBefore = x;
            }

            return count;
        }

        int vowelCount(string input)
        {
            int count = 0;

            foreach(char x in input)
            {
                foreach(char y in vowels)
                {
                    if(x == y)
                    {
                        count += 1;
                    }
                }
            }

            return (count);
        }

        int consonantCount(string input)
        {

            int NumberOfVowels = vowelCount(input);
            int NumberOfLetters = letterCount(input);

            int count = NumberOfLetters - NumberOfVowels;

            return (count);

        }

        int UpperCount(string input)
        {
            int count = 0;
            int yIndex = 0;

            foreach(char x in input)
            {
                yIndex = 0;

                foreach(char y in alphabet)
                {
                    if(x == y && yIndex > 25)
                    {
                        count += 1;
                    }

                    yIndex += 1;
                }
            }

            return count;
        }

        int LowerCount(string input)
        {

            int NumberOfLetters = letterCount(input);
            int NumberOfUpperLetters = UpperCount(input);

            int count = NumberOfLetters - NumberOfUpperLetters;

            return count;
        }
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            values.Add(sentenceCount(input));
            values.Add(vowelCount(input));
            values.Add(consonantCount(input));
            values.Add(UpperCount(input));
            values.Add(LowerCount(input));


            return values;
        }
    }
}
