
using System;
using System.Collections.Generic;
using System.Linq;

namespace WordsLibraryName
{
    public class PredictionOfInput
    {
        WordsLibrary WL = new WordsLibrary();
        HashSet<string> wordsSet;
        public PredictionOfInput()
        {
            wordsSet = new HashSet<string>(WL.words, StringComparer.OrdinalIgnoreCase);
        }

        public List<string> PredictWords(string input)
        {
            List<string> predictedWords = new List<string>();
            if (input.Length < 2)
            {
                return predictedWords;
            }
            predictedWords = PredictWordsStage1(input, wordsSet);
            if (!predictedWords.Any())
            {
                predictedWords = SpellCheckAndPredict(input, wordsSet);
            }
            return returnNoMoreThenThreePredictedWords(predictedWords);

        }
        private List<string> returnNoMoreThenThreePredictedWords(List<string> words)
        {
            int maxPredictedWords = 3;
            if (words.Count < maxPredictedWords) return words;
            Random random = new Random();
            while (words.Count > maxPredictedWords)
            {
                int index = random.Next(0, words.Count);
                words.RemoveAt(index);
            }
            return words;
        }
        private List<string> PredictWordsStage1(string input, HashSet<string> wordSet)
        {
            List<string> predictedWords = new List<string>();

            foreach (string word in wordSet)
            {
                if (word.ToLower().StartsWith(input, StringComparison.OrdinalIgnoreCase))
                {
                    predictedWords.Add(word.ToLower());
                }
            }

            return predictedWords;
        }

        private List<string> SpellCheckAndPredict(string input, HashSet<string> wordSet)
        {
            List<string> predictedWords = new List<string>();

            foreach (string word in wordSet)
            {
                if (IsCloseMatch(input, word.ToLower()))
                {
                    predictedWords.Add(word.ToLower());
                }
            }

            return predictedWords;
        }

        private bool IsCloseMatch(string input, string word)
        {
            int maxDistance = 1;
            int inputLength = input.Length;
            int wordLength = word.Length;

            if (Math.Abs(inputLength - wordLength) > maxDistance)
            {
                return false;
            }

            int[,] dp = new int[inputLength + 1, wordLength + 1];

            for (int i = 0; i <= inputLength; i++)
            {
                dp[i, 0] = i;
            }

            for (int j = 0; j <= wordLength; j++)
            {
                dp[0, j] = j;
            }

            for (int i = 1; i <= inputLength; i++)
            {
                for (int j = 1; j <= wordLength; j++)
                {
                    int cost = (input[i - 1] == word[j - 1]) ? 0 : 1;
                    dp[i, j] = Math.Min(Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1), dp[i - 1, j - 1] + cost);
                }
            }
            return dp[inputLength, wordLength] <= maxDistance;
        }

        public void AddNewWord(string newWord)
        {
            wordsSet.Add(newWord);
            WL.AddNewWord(newWord);
        }
    }
}
