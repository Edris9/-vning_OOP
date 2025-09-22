using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace Övning_OOP
{
    internal class inheritance
    {
        public string Name;
        public int Age;
        public string Address;
        public void Introduce()
        {
            Console.WriteLine($"Hej, jag heter {Name}, jag är {Age} år gammal och bor på {Address}.");
        }
        public void Askaboutnewobject()
        {
            Console.WriteLine("Vill du skapa ett nytt objekt tryck 1 annars 2 för att avsluta");
            if (Console.ReadLine() == "1")
            {
                Newobjcet student = new Newobjcet();
                student.Name = this.Name;      
                student.Age = this.Age;
                student.Address = this.Address;

                Console.WriteLine("Ange skola:");
                student.School = Console.ReadLine();

                student.Study();
            }
            else
            {
                return;
            }
        }
    }
    class Newobjcet : inheritance
    {
        public string School;
        public void Study()
        {
            Introduce();
            Console.WriteLine($"Jag studerar på {School}.");
        }
    }
}