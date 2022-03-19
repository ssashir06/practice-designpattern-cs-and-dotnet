using System;

namespace Coding.Exercise
{
    public interface IPerson
    {
        int Age { get; set; }

        string Drink();
        string DrinkAndDrive();
        string Drive();
    }

    public class Person : IPerson
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public class ResponsiblePerson : IPerson
    {
        private readonly Person person;

        public ResponsiblePerson(Person person)
        {
            this.person = person;
        }

        public int Age {
            get { return person.Age; }
            set { person.Age = value; }
        }

        public string Drink()
        {
            if (Age < 18)
            {
                return "too young";
            }
            return person.Drink();
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }

        public string Drive()
        {
            if (Age < 16)
            {
                return "too young";
            }
            return person.Drive();
        }
    }
}
