namespace StaticDataAndMembers;

public class SavingsAccount
{

    private static double currInterestRate;
    
    private double currBalance;

    public static double InterestRate { get; set; } = currInterestRate;

    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }

    static SavingsAccount()
    {
        Console.WriteLine("In static constructor!");
        currInterestRate = 0.04;
    }
}