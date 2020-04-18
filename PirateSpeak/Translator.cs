using System;
using System.Collections.Generic;
using System.Text;

namespace PirateSpeak
{
    public class Translator
    {
        public List<string> Translate(string jumbledLetters, List<string> possibleWords) 
        {
            var result = new List<string>();
            foreach (var word in possibleWords)
            {
                var charCount = word.Length;
                var matchCount = 0;
                foreach (var character in jumbledLetters)
                {
                    
                    if (word.Contains(character))
                    {
                        matchCount += 1;
                    }
                }
                if (charCount == matchCount)
                {
                    result.Add(word);                
                }
            }
            return result;
        }
    }
}
