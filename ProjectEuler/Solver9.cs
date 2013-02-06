using System;

namespace ProjectEuler
{
    public class Solver9 : ISolver
    {
        public int Solve()
        {
            return MyMath();
        }

        // 5 ms
        int MyMath()
        {
            // a + b + c = 1000
            // a^2 + b^2 = c^2
            //                 ____________
            // a + b - 1000 = \|a^2 + b^2
            // a^2 + b^2 + 1000^2 + 2ab - 2000a - 2000b = a^2 + b^2
            // 2ab + 1000000 = 2000a + 2000b
            // 
            // 500000 = 1000*a + 1000*b - a*b
            for (var i = 1; i < 999; i++)
                for (var j = 2; j < 999; j++)
                {
                    if (500000 == 1000*i + 1000*j - i*j)
                    {
                        var k = 1000 - i - j;
                        return i*j*k;
                    }
                }

            return 0;
        }

        // 36 sec.
        //int Loop()
        //{
        //    for (var i = 1; i < 999; i++)
        //        for (var j = 2; j < 999; j++)
        //            for (var k = 3; k < 999; k++)
        //            {
        //                if (Math.Abs(Math.Pow(i, 2) + Math.Pow(j, 2) - Math.Pow(k, 2)) < 0.1
        //                    && i + j + k == 1000)
        //                {
        //                    return i * j * k;
        //                }
        //            }

        //    return -1;
        //}
    }
}