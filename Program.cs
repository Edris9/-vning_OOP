namespace Övning_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hej välkommen till banken");

            Console.WriteLine("Tryck 1 för att testa encapsulation:Tryck 2 för att testa inheritance:Tryck 3 för att testa polymorphism:Tryck 4 för att testa abstrayion.");

            string val = Console.ReadLine();

            if (val == "1")
            {
                var account = new encapsulation_account_nnr();
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
            else if (val == "3")
            {
                Console.WriteLine("Ange kontotyp (1 - Vuxen, 2 - Student):");
                string type = Console.ReadLine();

                polymorphism account;
                if (type == "1")
                    account = new AdultAccount();
                else
                    account = new StudentAccount();
                account.AccountType();
            }
            else if (val == "4")
            {
                Console.WriteLine("Tryck 1 för att se din ränta.\nTryck 2 för att se dina avgifter.");
                string choice = Console.ReadLine();

                Account acou;
                if (choice == "1")
                {
                    acou = new SavingsAccount();
                }
                else
                {
                    acou = new CheckingAccount();
                }

                acou.DisplayInfo();
            }
        }
    }
}