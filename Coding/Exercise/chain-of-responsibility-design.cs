using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public abstract class Creature
    {
        public int Attack { get { return AttackBase + Game.ModifierAttack(this); } }
        public int Defense { get { return DefenceBase + Game.ModifierDefence(this); } }
        public int AttackBase { get; set; }
        public int DefenceBase { get; set; }
        public Game Game { get; }

        public Creature(Game game)
        {
            Game = game;
        }

        public abstract int ModifierAttack(Creature creature, int v);

        public abstract int ModifierDefence(Creature creature, int v);
    }

    public class Goblin : Creature
    {
        public Goblin(Game game) : base(game)
        {
            DefenceBase = AttackBase = 1;
        }

        public override int ModifierAttack(Creature creature, int v)
        {
            return 0;
        }

        public override int ModifierDefence(Creature creature, int v)
        {
            if (creature is Goblin && !creature.Equals(this))
            {
                v += 1;
            }
            return v;
        }
    }

    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game)
        {
            DefenceBase = AttackBase = 3;
        }

        public override int ModifierAttack(Creature creature, int v)
        {
            if (creature is Goblin && !creature.Equals(this))
            {
                v += 1;
            }
            return v;
        }
    }

    public class Game
    {
        public IList<Creature> Creatures = new List<Creature>();

        internal int ModifierAttack(Creature creature)
        {
            var v = 0;
            foreach (var c in Creatures)
            {
                v = c.ModifierAttack(creature, v);
            }
            return v;
        }

        internal int ModifierDefence(Creature creature)
        {
            var v = 0;
            foreach (var c in Creatures)
            {
                v = c.ModifierDefence(creature, v);
            }
            return v;
        }
    }
}
