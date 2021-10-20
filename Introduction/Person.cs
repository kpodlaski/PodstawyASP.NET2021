using System;
using System.Collections.Generic;
using System.Text;

namespace Introduction
{
    class Person
    {
        public long Pesel { private set; get; }
        public String Name;
        public string Surname;
        public String BirthDate { private set; get; }

        public Person(long pesel, string Name, string surname, string birthDate)
        {
            Pesel = pesel;
            this.Name = Name;
            Surname = surname;
            BirthDate = birthDate;
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


    }
}
