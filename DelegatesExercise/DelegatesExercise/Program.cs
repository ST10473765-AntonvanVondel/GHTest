namespace DelegatesExercise
{
    internal class Program
    {
        static Methods methods = new Methods();
        static void Main(string[] args)
        {
            Console.Write("Enter mark: ");
            int mark = validInt(Console.ReadLine());
            while (mark < 0)
            {
                Console.Write("Try again: ");
                mark = validInt(Console.ReadLine());
            }
            methods.Output(mark);
        }

        static int validInt(string inp)
        {
            try
            {
                return int.Parse(inp);
            } catch (FormatException)
            {
                Console.WriteLine("Invalid integer value");
                return -1;
            }
        }
    }
}
