using System;
using System.Collections.Generic;

namespace Introduction
{
    class Program
    {

        static void Main()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person(98021354321L, "Janina", "Kowalska", "1998/02/13"));
            persons.Add(new Person(98021354321L, "Janina", "Kowalska", "1998/02/13"));
            persons.Add(new Person(88121354321L, "Tadeusz", "Kowalski", "1988/12/13"));
            for(int i=0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i]);
            }
            Console.WriteLine("==============");
            foreach(Person p in persons){
                Console.WriteLine(p);
            }
            //persons.Remove(new Person(98021354321L, "Janina", "Kowalska", "1998/02/13"));
            //persons.Remove(new Person(98021354321L, "Janina", "Kowalska", "1998/02/13"));
            persons.Add(persons[0]);
            Console.Write(persons.Count);
            Console.WriteLine("==============");
            Console.WriteLine("=====SET======");
            Console.WriteLine("==============");
            HashSet<Person> setP = new HashSet<Person>();
            foreach (Person p in persons)
            {
                setP.Add(p);
                Console.WriteLine("Dodano " + p);
                Console.WriteLine("Aktualny rozmiar " + setP.Count);
            }
            Console.WriteLine("==============");
            Console.WriteLine("=====DICT=====");
            Console.WriteLine("==============");
            Dictionary<Person, Double> salary = new Dictionary<Person, double>();
            salary[persons[0]] = 1253.2;
            salary[persons[1]] = 2432.1;
            salary[persons[2]] = 1564.8;
            foreach(Person p in salary.Keys)
            {
                Console.WriteLine(p.Name + " " + p.Surname + " " + salary[p]);
            }
            Console.WriteLine("===============");
            Console.WriteLine("====POCZĄTEK===");
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Pesel + " " + p.Surname);
            }
            persons.Sort();
            persons.Sort(new CompareBySurname());
            persons.Sort(Person.GetComparerByName());
            Console.WriteLine("===============");
            Console.WriteLine("==POSORTOWANE==");
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Pesel+" "+ p.Surname);
            }

        }
        static void Main_1()
        {
            Console.WriteLine("Hello World!");

            Person p1 = new Person(98021354321L, "Janina", "Kowalska","1998/02/13");
            Person p2 = new Person(98021354321L, "Janina", "Kowalska", "1998/02/13");
            Console.WriteLine("Osoba: "+ p1);
            if (p1 == p2)
            {
                Console.WriteLine("Ten sam obiekt");
            }
            else
            {
                Console.WriteLine("Różne obiekty");
            }
            if (p1.Equals(p2))
            {
                Console.WriteLine("Ta sama osoba");
            }
            else
            {
                Console.WriteLine("Różne osoby");
            }
        }
    }
}







