using System;

namespace Calculator
{
    public sealed class Engine
    {
        public int Sum(int a, int b)
        {
            try
            {
                if (a == 0 || b == 0)
                {
                    throw new ArgumentNullException(
                        "The arguments a and b must be greater than 0.");
                }

                return a + b;
            }
            catch (Exception exception)
            {
                throw new Exception("An error occured during the Sum calculation", exception);
            }
        }
    }
}