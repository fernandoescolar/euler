using System.Linq;

namespace ProjectEuler
{
    public class Solver16 : ISolver
    {
        public int Solve()
        {
            var bigNumber = new byte[310];
            bigNumber[0] = 2;
            for(var i = 2; i<=1000; i++)
            {
                Double(bigNumber);
            }

            return bigNumber.Sum(x => x);
        }

        static void Double(byte[] bytes)
        {
            var carry = false;
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] <<= 1;
                if (carry)
                {
                    bytes[i]++;
                    carry = false;
                }

                if (bytes[i] >= 10)
                {
                    carry = true;
                    bytes[i] -= 10;
                }
            }
        }
    }
}
