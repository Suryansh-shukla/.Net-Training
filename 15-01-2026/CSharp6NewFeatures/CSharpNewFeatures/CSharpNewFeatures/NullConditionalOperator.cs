using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static CSharpNewFeatures.SuperHero;
namespace CSharpNewFeatures
{
    class NullConditionalOperator
    {

        private static void Main(string[] args)
        {
            SuperHero hero = new SuperHero();
            hero.SuperPower = "Invisible";
            if (hero.SuperPower == String.Empty)
            {
                hero = null;
            }
            /* old syntax of checking if an instance is null or not */
          //  WriteLine(hero != null ? hero.SuperPower : "You aint a super hero.");
            /* New null conditional operator */
                WriteLine(hero?.SuperPower ?? "You aint a super hero.");

            Person p1 = new Person();
            p1.Name = "Alok";
            p1.Age = 32;

            p1.HomeAddress = new Address();//Ref type property
            p1.HomeAddress.FlatNo = 1601;
            p1.HomeAddress.Apartment = "Atlanta";
            p1.HomeAddress.City = "Pune";
            p1.HomeAddress.State = "MH";

            ReadLine();
        }
    }
    public class SuperHero
    {
        public string SuperPower { get; set; } = "";
    }

    public class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Person Spouse { get; set; }
        public Address HomeAddress { get; set; }
    }

    public class Address
    {
        public int FlatNo { get; set; }
        public string Apartment { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}

