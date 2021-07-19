using System.Collections;
using static System.Console;

namespace Chapter_04
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int? num = null;
            WriteLine($"{num ?? 0}");

            num = 99;
            WriteLine($"{num ?? 0}");

            string str = null;
            WriteLine($"{str ?? "Default"}");

            str = "Specific";
            WriteLine($"{str ?? "Default"}");
        }

    }
}
