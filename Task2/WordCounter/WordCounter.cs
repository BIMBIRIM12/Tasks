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

        public char[] SetPunctuations(string stringFromUser)
        {
            var arraySize = stringFromUser.Length;
            char[] setPunctuations = new char[arraySize];
            for (var i = 0; i < stringFromUser.Length; i++)
            {
                if (char.IsNumber(stringFromUser[i])||char.IsWhiteSpace(stringFromUser[i]) || char.IsPunctuation(stringFromUser[i]) || char.IsNumber(stringFromUser[i]))
                {
                    setPunctuations[i] = stringFromUser[i];
                }
            }
            return setPunctuations;
        }
        public string[] SetWords (char[] setPunctuations,string stringFromUser)
        {
            string[] setWords = stringFromUser.Split(setPunctuations);
            return setWords;
        }
        public object [,] CounterWords (string[] setWords)
        {
            var quantity = new List<int>();
            var word = new List<string>();
            bool[] isThereWord = new bool[setWords.Length];
            for(var i = 0;i<setWords.Length;i++)
            {
                if (!isThereWord[i])
                {
                    word.Add(setWords[i]);
                    quantity.Add(1);
                    isThereWord[i] = true;

                    for(var j = 0;j<setWords.Length;i++)
                    {
                        if(!isThereWord[j] && word[i].ToLower() == setWords[j].ToLower())
                        {    quantity[i]++;
                            isThereWord[j] = true;
                        }
                    }
                }
            }
        var wordQuantity = new object[word.Count, 2];
            for(var i = 0;i < word.Count; i++)
            {
                wordQuantity[i,0] = word[i];
                wordQuantity[i, 1] = quantity[i];              
            }
            return wordQuantity;

        }
    }
}
