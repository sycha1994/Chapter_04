using System.Collections;
using static System.Console;

namespace Chapter_04
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 10;
            string b = a == 0 ? "abc" : "efg";
            WriteLine(b);

            int aa = 0xF0 | 0x0F;
            WriteLine(aa);

            int a1 = 8 >> 1;
            int b1 = a >> 2;
            WriteLine(a1);
            WriteLine(b1);
        }

    }
}
