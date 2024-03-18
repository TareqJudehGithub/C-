namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables\n");

            /* 
             string  - text
             char    - one letter
            double, float, decimal - decimals 
            bool - logicals


            */

            string name = "Tareq Judeh";
            int age = 48;
            int retirementYearsleft = 17;
            int retrimentAge = age + retirementYearsleft;
            bool isRetired = false;

            // String concatenation
            Console.WriteLine("MY name is " + name + ". I'm " + age + " years old.");
            // String interpolation
            Console.WriteLine($"My name is {name}. I'm {age} years old.");
            // Formatted string
            Console.WriteLine("My name is {0}. I'm {1} years old.", name, age);

            Console.WriteLine($"The retirement age is: {retrimentAge}.");

            Console.WriteLine($"Am I retired? {isRetired}");

        }
    }
}
