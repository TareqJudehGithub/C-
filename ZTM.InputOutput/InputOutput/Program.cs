namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console: Input & Output\n");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"My name is: {name}");
            Console.ReadKey();
        }
    }
}
