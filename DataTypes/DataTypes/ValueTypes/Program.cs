namespace ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ValueTypes\n");

            bool enabled = false;
            Console.WriteLine(enabled);
            enabled = true;
            Console.WriteLine(enabled);
            Console.WriteLine("");

            int a = 0, b = 5, c = -7;

            int multiply = b * c;
            int divide = c / b;
            int subtract = a - b;



            float f = 3.5f;                             // 32 bits floating point number.
            double g = 7.8d;                        // 64 bits floating point number.
            decimal dec = 7.15m;                // 128 bits floating point number.        



        }
    }
}
