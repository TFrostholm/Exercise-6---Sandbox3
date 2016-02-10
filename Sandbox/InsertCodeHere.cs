using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int a = 7;
            int b = 12;

            Boolean bool1 = (a < 10);
            Console.WriteLine(bool1);

            Boolean bool2 = (a >= 7);
            Console.WriteLine(bool2);

            Boolean bool3 = (a != 12);
            Console.WriteLine(bool3);

            Boolean bool4 = (a < 10 && a > 5);
            Console.WriteLine(bool4);

            Boolean bool5 = (a < 10 && b != 10);
            Console.WriteLine(bool5);

            Boolean bool6 = (a > 10 || b > 10);
            Console.WriteLine(bool6);

            Boolean bool7 = ((b >= 0 && b <= 20) && (a < 8));
            Console.WriteLine(bool7);

            Boolean bool8 = ((a + b) > (a - b));
            Console.WriteLine(bool8);

            // The LAST line of code should be ABOVE this line
        }
    }
}
