//UniversityInfo universityInfo = new UniversityInfo();

//universityInfo.UniversityName = "EWU";
//universityInfo.UniLocation = "Aftab";

//universityInfo.FullUniInfo();


//BankAccount bankAccount = new BankAccount();
//bankAccount.Balance = 20;
//bankAccount.Deposite(50);
//bankAccount.Withdraw(20);


public class UniversityInfo
{
    private string uniName;
    private string uniLocation;

    public string UniversityName
    {
        get { return uniName; }
        set { uniName = value; }
    }
    public string UniLocation
    {
        get { return uniLocation; }
        set { uniLocation = value; }
    }
    public void FullUniInfo()
    {
        Console.WriteLine($"{UniversityName}, {UniLocation}");
    }
}

public class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void Deposite(decimal amount)
    {
        balance = balance + amount;
        Console.WriteLine("Now balance is: "+ balance);
    }

    public void Withdraw(decimal amount)
    {
        balance = balance - amount;
        Console.WriteLine("Now balance is: "+ balance);
    }
}