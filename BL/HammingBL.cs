using System;

namespace BL
{
    public class HammingBL
    {
        public static int HammingDistance(string A, string B)
        {
            if (A is null)
                throw new ArgumentNullException(nameof(A));

            if (B is null)
                throw new ArgumentNullException(nameof(B));

            if (A.Length != B.Length)
            {
                throw new ArgumentException("variable lengths don't match");
            }

            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A.ElementAt(i) != B.ElementAt(i))
                {
                    result++;
                }
            }

            return result;
        }
    }
}