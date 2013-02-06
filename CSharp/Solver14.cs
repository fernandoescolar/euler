namespace ProjectEuler
{
    public class Solver14 : ISolver
    {
        public int Solve()
        {
            var result = 0;
            var last = 0;
            for (var i = 1; i < 1000000; i++)
            {
                var temp = CountSteps(i);
                if (last < temp)
                {
                    last = temp;
                    result = i;
                }
            }


            return result;
        }

        static int CountSteps(int number)
        {
            var counter = 0;
            long temp = number;
            do
            {
                temp = Step(temp);
                counter++;
            } while (temp > 1);

            return counter;
        }

        static long Step(long number)
        {
            // return number%2 == 0 ? number/2 : number*3 + 1;
            return (number & 1) == 0 ? number >> 1 : number * 3 + 1;
        }
    }
}