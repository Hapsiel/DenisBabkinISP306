using System;

namespace LibTest
{
    public class Sum
    {
        public int Method(int x, int y)
        {
            int Sum = x + y;
            int Dev = x - y;
            int res = Sum * Dev;
            return res;
        }
    }
}
