using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Exercise
{
    public class Participant
    {
        private readonly Mediator mediator;

        public int Value { get; set; }

        public Participant(Mediator mediator)
        {
            this.mediator = mediator;
            this.mediator.Join(this);
        }

        public void Say(int n)
        {
            mediator.Boadcast(this, n);
        }

        public void Receive(int n)
        {
            this.Value += n;
        }
    }

    public class Mediator
    {
        private readonly List<Participant> participants = new List<Participant>();

        public void Join(Participant participant)
        {
            this.participants.Add(participant);
        }

        public void Boadcast(Participant participant, int n)
        {
            foreach (var recever in participants.Where(p => p != participant))
            {
                recever.Receive(n);
            }
        }
    }
}
