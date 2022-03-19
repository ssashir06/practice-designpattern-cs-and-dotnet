//using System;
//using System.Collections.Generic;

//namespace Coding.Exercise
//{
//    public class Person
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }

//        public Person(int id, string name)
//        {
//            Id = id;
//            Name = name;
//        }
//    }

//    public class PersonFactory
//    {
//        private List<WeakReference<Person>> list = new List<WeakReference<Person>>();
//        public Person CreatePerson(string name)
//        {
//            var instance = new Person(list.Count, name);
//            list.Add(new WeakReference<Person>(instance));
//            return instance;
//        }
//    }
//}
