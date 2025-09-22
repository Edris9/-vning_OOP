namespace Övning_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hej välkommen till banken");
 inheritance
            Console.WriteLine("Tryck 1 för att testa encapsulation:\nTryck 2 för att testa inheritance:");

            string val = Console.ReadLine();

            if (val == "1")
            {
                encapsulation_account_nnr account = new encapsulation_account_nnr();
                account.GetPersonID(1234567890);
                account.Deposit(1000);
                account.Withdraw(500);
                Console.WriteLine("Ditt saldo är: " + account.GetBalance());
            }
            else if (val == "2")
            {
                inheritance student = new inheritance();
                Console.WriteLine("Ange namn:");
                student.Name = Console.ReadLine();
                Console.WriteLine("Ange ålder:");
                student.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange adress:");
                student.Address = Console.ReadLine();
                student.Askaboutnewobject();
            }

            encapsulation_account_nnr account = new encapsulation_account_nnr();
            account.GetPersonID(1234567890);
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine("Ditt saldo är: " + account.GetBalance());




 master
        }
    }
}