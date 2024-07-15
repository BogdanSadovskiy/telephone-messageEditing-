using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordsLibrary
{
    public class WordsTree
    {
        public List<char> rootChar;
        WordsTree nextChar;


        public bool searchChar(char c)
        {
            if(rootChar.Contains(c)) return true;
            return false;
        }
        public bool regularCheck(string word)
        {
            string onlyCharPattern = "[a-z]+";
            return Regex.IsMatch(word, onlyCharPattern);
        }

        public void setWord(string word)
        {
            if(string.IsNullOrEmpty(word)) return;
            string tmpWord = word.ToLower();
            char currentChar = tmpWord[0];
            if (tmpWord.Length > 1) tmpWord = tmpWord.Substring(1);
            if (rootChar == null) rootChar = new List<char>();

            if (!searchChar(currentChar)) rootChar.Add(currentChar);

            if (tmpWord.Length > 0)
            {
                if (nextChar == null) { nextChar = new WordsTree(); }
                WordsTree tmp = nextChar;
                tmp.setWord(tmpWord);
            }

        }
        public List<string> predictedWordsStage1(string inputed) {
            string currentWord = inputed.ToLower();
            if (string.IsNullOrEmpty(currentWord) || regularCheck(currentWord)) { return null; }
            return predictedWordsStage2(currentWord);

        }
        public List<string> predictedWordsStage2(string inputed)
        {
            if(inputed.Length <1) { return null; }
            if (!searchChar(inputed[0])) { }
            List<string> words = new List<string>();


        }

    }

    public class WordsLibrary
    {
        List<char> rootChar;


    }
}
