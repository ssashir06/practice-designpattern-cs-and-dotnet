using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Game
    {
        public event EventHandler<RatCountEventArgs> RatsUpdated;
        public void UpdateCountOfRats(int count)
        {
            RatsUpdated?.Invoke(this, new RatCountEventArgs() { Count = count });
        }
    }

    public class RatCountEventArgs
    {
        public int Count { get; set; }
    }

    public class Rat : IDisposable
    {
        public int Attack = 1;
        public static Dictionary<Game, int> AttackMap = new Dictionary<Game, int>();
        private readonly Game game;

        public Rat(Game game)
        {
            this.game = game;
            if (!AttackMap.ContainsKey(game))
            {
                AttackMap[game] = 0;
            }
            AttackMap[game]++;

            game.RatsUpdated += Game_RatsUpdated;

            game.UpdateCountOfRats(AttackMap[game]);
        }

        private void Game_RatsUpdated(object sender, RatCountEventArgs e)
        {
            this.Attack = e.Count;
        }

        public void Dispose()
        {
            this.game.RatsUpdated -= Game_RatsUpdated;
            AttackMap[this.game]--;
            this.game.UpdateCountOfRats(AttackMap[game]);
        }
    }
}

