using System;

namespace MyBudget
{
    public class CreateBudget : IBudgetAction
    {
        public void Execute()
        {
            Console.Write("Choose a month (mmm): ");
            var input = Console.ReadLine();
            var month = Month.FromMMM(input);
            Console.Write("Choose a year (yyyy): ");
            input = Console.ReadLine();
            var year = int.Parse(input);

            var budget = new Budget(month, year);
        }
    }
}
