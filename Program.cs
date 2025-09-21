namespace Övning_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej välkommen till banken");
            encapsulation_account_nnr account = new encapsulation_account_nnr();
            account.GetPersonID(1234567890);
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine("Ditt saldo är: " + account.GetBalance());




        }
    }
}
