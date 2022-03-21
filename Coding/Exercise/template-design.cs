using System;
using System.Linq;

namespace Coding.Exercise
{
    public class Creature
    {
        public int Attack, Health;

        public Creature(int attack, int health)
        {
            Attack = attack;
            Health = health;
        }
    }

    public abstract class CardGame
    {
        public Creature[] Creatures;

        public CardGame(Creature[] creatures)
        {
            Creatures = creatures;
        }

        // returns -1 if no clear winner (both alive or both dead)
        public int Combat(int creature1, int creature2)
        {
            StartOfCombat();
            Creature first = Creatures[creature1];
            Creature second = Creatures[creature2];
            Hit(first, second);
            Hit(second, first);
            bool firstAlive = first.Health > 0;
            bool secondAlive = second.Health > 0;
            EndOfCombat();
            if (firstAlive == secondAlive) return -1;
            return firstAlive ? creature1 : creature2;
        }

        protected abstract void EndOfCombat();
        protected abstract void StartOfCombat();

        protected void Hit(Creature attacker, Creature other)
        {
            other.Health -= attacker.Attack;
        }
    }

    public class TemporaryCardDamageGame : CardGame
    {
        private Creature[] CreaturesBackup = new Creature[0];

        public TemporaryCardDamageGame(Creature[] creatures) : base(creatures)
        {
        }

        protected override void StartOfCombat()
        {
            CreaturesBackup = Creatures
                .Select(c => new Creature(c.Attack, c.Health))
                .ToArray();
        }

        protected override void EndOfCombat()
        {
            Creatures = CreaturesBackup;
        }
    }

    public class PermanentCardDamage : CardGame
    {
        public PermanentCardDamage(Creature[] creatures) : base(creatures)
        {
        }

        protected override void EndOfCombat()
        {
        }

        protected override void StartOfCombat()
        {
        }
    }
}