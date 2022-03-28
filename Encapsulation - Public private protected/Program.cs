using Encapsulation___Public_private_protected.Models;
using System;

namespace Encapsulation___Public_private_protected
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song();

            s1.Name = "sadsaddsfsfsdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffs";
            s1.AddRating(3);
            s1.AddRating(1);
            Console.WriteLine(s1.GetAverageRating() );
            s1.Genre = "Romck";
        }
    }
}
