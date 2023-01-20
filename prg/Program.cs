using System;
using System.Collections.Immutable;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[] {"Jesper", "Gabriel", "Fowzi", "Edvin", "Anton", "Hugo"};
            Array.Sort(namn);

            Console.WriteLine(namn[0]);

        }
    }
}
