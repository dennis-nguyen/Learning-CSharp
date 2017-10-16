using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("It is the perfect time to go to the beach");
                    break;
                default:
                    Console.WriteLine("I don't understand that season");
                    break;
            }
        }

    }
}

