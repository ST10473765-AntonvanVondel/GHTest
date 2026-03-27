using System;
using System.Collections.Generic;
using System.Text;


delegate int MarkProcessor(int inp);
namespace DelegatesExercise
{
    internal class Methods
    {
        public int AddBonus(int inp) { return inp + 5; }
        public int CapMark(int inp) { if (AddBonus(inp) > 100) { return 100; } else { return AddBonus(inp); } }
        public int PassStatus(int inp) { if (AddBonus(inp) >= 50) { return 1; } else { return 0; } }
        public Methods()
        {
            Console.WriteLine("Welcome to the Exercise");
        }

        public void Output(int y)
        {
            Console.Write("Bonus added to mark: ");
            ProcessMark(y, AddBonus);
            Console.Write($"Mark Capped: ");
            ProcessMark(y, CapMark);
            Console.Write("Pass Status: ");
            ProcessMark(y, PassStatus);
        }
        public void ProcessMark(int x, MarkProcessor operation)
        {
            if (operation == PassStatus)
            {
                if (operation(x) == 0)
                {
                    Console.WriteLine("Failed");
                }
                else if (operation(x) == 1)
                {
                    Console.WriteLine("Passed");
                }
            }
            else
            {
                Console.WriteLine(operation(x));
            }

        }
    }
}
