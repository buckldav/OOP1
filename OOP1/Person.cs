using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Person
    {
        // Constructor that takes no arguments:
        public Person()
        {
            Name = "unknown";
            FavoriteMovie = "unknown";
        }

        // Constructor that takes one argument:
        public Person(string name)
        {
            Name = name;
            FavoriteMovie = "unknown";
        }

        // Properties
        public string Name { get; }
        public string FavoriteMovie { get; set; }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return $"{Name}'s favorite movie is {FavoriteMovie}.";
        }
    }
}
