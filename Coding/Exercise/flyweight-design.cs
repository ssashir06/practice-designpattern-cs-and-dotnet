using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coding.Exercise
{
    public class Sentence
    {
        private WordToken[] wordTokens;
        private string[] sentences;
        public Sentence(string plainText)
        {
            sentences = plainText.Split(' ');
            wordTokens = Enumerable.Range(0, sentences.Count())
                .Select(_ => new WordToken())
                .ToArray();
        }

        public WordToken this[int index]
        {
            get { return wordTokens[index]; }
        }

        public override string ToString()
        {
            var sentencesNew = new List<string>();
            for (var i = 0; i < wordTokens.Count(); i++)
            {
                if (wordTokens[i].Capitalize)
                {
                    sentencesNew.Add(sentences[i].ToUpper());
                }
                else
                {
                    sentencesNew.Add(sentences[i]);
                }
            }
            return string.Join(" ", sentencesNew);
        }

        public class WordToken
        {
            public bool Capitalize;
        }
    }
}
