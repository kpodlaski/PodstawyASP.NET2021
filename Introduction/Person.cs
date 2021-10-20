using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Introduction
{
    class Person : IComparable<Person>
    {
        public long Pesel { private set; get; }
        public String Name;
        public string Surname;
        public String BirthDate { private set; get; }
        private long sortPesel;

        public Person(long pesel, string Name, string surname, string birthDate)
        {
            Pesel = pesel;
            this.Name = Name;
            Surname = surname;
            BirthDate = birthDate;
            int _month0 = (int)((this.Pesel / 10000000L) % 100);
            this.sortPesel = this.Pesel;
            if (_month0 > 12)
            {
                this.sortPesel = 100000000000L;
            }
        }

        public override string ToString()
        {
            return Name + " " + Surname + " pesel:" + Pesel;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Pesel == person.Pesel;
        }

        Random rand = new Random();
        public override int GetHashCode()
        {
            //NIE stosować return rand.Next();
            return HashCode.Combine(Pesel);
        }

        public int CompareTo(Person p)
        {
            // Os najmłodszego do najstarszego po wieku
            //10000000L
            //98021354321

            return Math.Sign(p.sortPesel - this.sortPesel);
        }

        static public IComparer<Person> GetComparerByName()
        {
            return new ComparerByName();
        }


        private class ComparerByName : IComparer<Person>
        {
            public int Compare(Person x,  Person y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
    


    class CompareBySurname : IComparer<Person>
    {
        public int Compare(Person x,  Person y)
        {
            return x.Surname.CompareTo(y.Surname);
        }
    }
}
