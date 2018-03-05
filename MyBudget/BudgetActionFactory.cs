using System;

namespace MyBudget
{
    public static class BudgetActionFactory
    {
        public static IBudgetAction Create(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.C) { return new CreateBudget(); }
            if (keyInfo.Key == ConsoleKey.O) { return new OpenBudget(); }
            return new ExitBudget();
        }

        private class ExitBudget : IBudgetAction
        {
            public void Execute()
            {
                Console.WriteLine("Exiting Program.");
            }
        }
    }
}
