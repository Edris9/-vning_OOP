internal class polymorphism
{
    public virtual void AccountType()
    {
        Console.WriteLine("Vanligt konto");
    }
}

class AdultAccount : polymorphism
{
    public override void AccountType()
    {
        Console.WriteLine("Vuxenkonto - ingen avgift!");
    }
}

class StudentAccount : polymorphism
{
    public override void AccountType()
    {
        Console.WriteLine("Studentkonto - 50% rabatt!");
    }
}