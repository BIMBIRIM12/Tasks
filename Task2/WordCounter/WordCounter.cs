using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class WordCounter
    {
        /*public string CheckString(string stringFromUser)
        {
            if (stringFromUser == null)
            {
                throw new ArgumentException("String is empty"); 
            }
            for (var i = 0; i < stringFromUser.Length; i++)
            {
                if (char.IsLetter(stringFromUser[i]))
                {
                    if (stringFromUser[i] < 'z' && stringFromUser[i] > 'a' || stringFromUser[i] < 'Z' && stringFromUser[i] > 'A')
                    {
                        throw new ArgumentOutOfRangeException("Uncorrect value");
                    }
                }
            }
            return stringFromUser; 
        } */
     
        public string[] SetWords (string stringFromUser)
        {
            string[] setWords = stringFromUser.Split(' ', ',' , '.');
            return setWords;
        }
        public object [,] CounterWords (string[] setWords)
        {
            var quantity = new List<int>();
            var word = new List<string>();
            for (var i = 0; i < setWords.Length; i++)
            {
                word.Add(setWords[i]);
                quantity.Add(0);
                for (var j = 0; j < setWords.Length; j++)
                {
                   if( word[i].ToLower() == setWords[j].ToLower())
                    {
                        quantity[i]++;
                    }
                }
            }
            var wordQuantity = new object[setWords.Length, 2];
            for (var i = 0; i < setWords.Length; i++)
            {
                wordQuantity[i, 0] = word[i];
                wordQuantity[i, 1] = quantity[i];

            }           
            return wordQuantity;
                 

                  
                 
             
            

        }
    }
}
