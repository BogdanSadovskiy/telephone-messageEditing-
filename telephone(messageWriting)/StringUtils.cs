
using System;
using System.Collections.Generic;
using WordsLibraryName;

namespace telephone_messageWriting_
{
    public class StringUtils
    {

        PredictionOfInput predictionOfInput = new PredictionOfInput();


        public string GetLastWord(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            string tmp = input;
            int lastIndex = tmp.LastIndexOf(' ');

            if (lastIndex == tmp.Length - 1)
                return string.Empty;

            if (lastIndex == -1)
                return tmp;
            string lastWord = tmp.Substring(lastIndex + 1);

            return lastWord;
        }


        public List<string> PredictWords(string input)
        {
            return predictionOfInput.PredictWords(input);
        }


        public List<string> ChangeStringLetterIfInputLetterUppercased(string input, List<string> list)
        {
            if (list == null || list.Count == 0) return list;
            if (char.IsUpper(input[0]))
            {
                List<string> upperList = new List<string>();
                foreach (string str in list)
                {
                    upperList.Add(char.ToUpper(str[0]) + str.Substring(1));
                }
                return upperList;
            }
            return list;
        }

        public string ReplaceLastWord(string input, string newLastWord)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return newLastWord;
            }
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                words[words.Length - 1] = newLastWord;
            }
            else
            {
                return newLastWord;
            }

            string result = string.Join(" ", words);

            return result;
        }

        public void AddNewWord(string newWord)
        {
            predictionOfInput.AddNewWord(newWord);
        }
    }

}

