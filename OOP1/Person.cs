using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Person
    {
        // *** FIELDS ***
        private string name;
        private string favoriteMovie;

        // Constructor that takes no arguments:
        public Person()
        {
            name = "unknown";
            favoriteMovie = "unknown";
        }

        // Constructor that takes one argument:
        public Person(string name)
        {
            this.name = name;
            favoriteMovie = "unknown";
        }

        // *** METHODS ***
        public string GetName()
        {
            return name;
        }

        public string GetFavoriteMovie()
        {
            return favoriteMovie;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetFavoriteMovie(string movie)
        {
            favoriteMovie = movie;
        }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return $"{name}'s favorite movie is {favoriteMovie}.";
        }
    }
}
