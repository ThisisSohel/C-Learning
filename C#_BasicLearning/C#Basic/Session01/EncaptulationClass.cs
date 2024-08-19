
//StudentInfo student = new StudentInfo();
//student.Name = "Sohel";
//student.StudentAge = 24;
//Console.WriteLine(student.Name);
//Console.WriteLine(student.StudentAge);


//BankAccount bankAccount = new BankAccount();
//bankAccount.SetBalance = 2424648;
//bankAccount.BalanceCheck();
//bankAccount.Deposite(50);
//bankAccount.WithDraw(20);

//UniversityInfo universityInfo = new UniversityInfo();
//universityInfo.UniversityName = "EWU";
//universityInfo.UniversityId = 1;
//universityInfo.UniversityAddress = "Aftabnagar, 1202";
//universityInfo.FullUniversityInfo();


public class StudentInfo
{
    private string studentName;
    private int studentAge;

    public string Name 
    {
        get {  return studentName; }
        set { studentName = value; }
    }
    public int StudentAge
    {
        get { return studentAge; }
        set { studentAge = value; }
    }
}

public class BankAccount
{
    private decimal balance;
    public decimal SetBalance
    {
        get { return balance; }
        set { balance = value; }
    }
    public void BalanceCheck()
    {
        Console.WriteLine("Your balance is without any transaction- " + balance);
    }
    public void Deposite(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Balance can not be zero or negative number!");
        }
        balance = balance + amount;
        Console.WriteLine($"You current balance is {balance} after adding {amount}");
    }
    public void WithDraw(decimal amount)
    {
        if(balance < amount)
        {
            Console.WriteLine("Insufficient Balance!");
        }
        balance = balance - amount;
        Console.WriteLine($"You current balance after withwraw of {amount} is {balance} tk");
    }
}

public class UniversityInfo
{
    private string universityName;
    private int universityId;
    private string universAddress;

    public string UniversityName
    {
        get { return universityName; }
        set { universityName = value; }
    }
    public int UniversityId
    {
        get { return universityId; }
        set { universityId = value; }
    }
    public string UniversityAddress
    {
        get { return universAddress; }
        set { universAddress = value; }
    }

    public void FullUniversityInfo()
    {
        Console.WriteLine($"The university name is {universityName}. University Id is {universityId} and the university address is {universAddress}"); 
    }
}

