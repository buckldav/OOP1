using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("David");
            me.FavoriteMovie = "Bill and Ted";
            Person friend = new Person("George");
            Console.WriteLine(me);
            Console.WriteLine(friend);
            Console.ReadKey();
        }
    }
}
