namespace Övning_OOP
{
    abstract class Account
    {
        public abstract void DisplayInfo();
    }

    class SavingsAccount : Account
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Sparkonto - 2% ränta");
        }
    }

    class CheckingAccount : Account
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Lönekonto - inga avgifter");
        }
    }
}