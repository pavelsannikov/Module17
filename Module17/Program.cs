class Program
{
    static void Main()
    {
        Account account1 = new RegularAccount(1000, 10.0);
        account1.CalculateInterest();

        Account account2 = new SalaryAccount(100, 10.0);
        account2.CalculateInterest();
    }
}
abstract public class Account
{
    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }
    public Account(double balance, double interest)
    {
        Balance = balance;
        Interest = interest;
    }
    public abstract void CalculateInterest();
}
public class RegularAccount : Account
{
    public RegularAccount(double balance, double interest) : base(balance, interest)
    { }
    public override void CalculateInterest()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;

        if (Balance < 50000)
            Interest -= Balance * 0.4;
        Console.WriteLine("Обычный {0}",Interest);
    }
}
public class SalaryAccount : Account
{
    public SalaryAccount(double balance, double interest) : base(balance, interest)
    { }
    public override void CalculateInterest()
    {
        Interest = Balance * 0.5;
        Console.WriteLine("Зарплатный {0}", Interest);
    }
}