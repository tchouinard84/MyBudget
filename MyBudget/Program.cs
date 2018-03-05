using System;

namespace MyBudget
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyBudget.");
            Console.WriteLine("Please choose an option.");
            Console.WriteLine("\t(C)reate New Budget");
            Console.WriteLine("\t(O)pen Existing Budget");
            Console.WriteLine("\t(E)xit Program");
            Console.WriteLine();

            BudgetActionFactory.Create(Console.ReadKey()).Execute();
        }
    }
}
