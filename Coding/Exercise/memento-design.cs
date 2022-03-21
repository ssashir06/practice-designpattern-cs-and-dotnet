using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Exercise
{
    public class Token
    {
        public int Value { get; set; } = 0;

        public Token(int value)
        {
            this.Value = value;
        }
    }

    public class Memento
    {
        public Token[] TokensSnapshot { get; }

        public Memento(List<Token> tokens)
        {
            this.TokensSnapshot = tokens
                .Select(t => new Token(t.Value))
                .ToArray();
        }
    }

    public class TokenMachine
    {
        public List<Token> Tokens { get; } = new List<Token>();

        public Memento AddToken(int value)
        {
            return this.AddToken(new Token(value));
        }

        public Memento AddToken(Token token)
        {
            Tokens.Add(token);
            var memento = new Memento(Tokens);
            return memento;
        }

        public void Revert(Memento m)
        {
            Tokens.Clear();
            foreach (var t in m.TokensSnapshot)
            {
                Tokens.Add(t);
            }
        }
    }
}
