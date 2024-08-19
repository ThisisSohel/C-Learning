Console.WriteLine(weekDays.Friday);

var weekDayNum = (int)weekDays.Friday;
Console.WriteLine(weekDayNum);
Person person = new Person()
{
    Id = 1,
    Name = "Sohel",
};
person.PrintDetails();

Person p1 = new Person();
p1.Id = 2;
p1.Name = "Rakib";
p1.PrintDetails();

Person p2 = new Person(3, "Joe");
p2.PrintDetails();
Person p5 = new Person();
p5.Id = 4;
p5.Name = "5";
X x = new X();
public struct Person
{
     private int _id;
     private string _name;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Person(int id , string name)
    {
        _id = id;
        _name = name;
    }
    public void PrintDetails()
    {
        Console.WriteLine($" Id = {_id} and Name = {_name}");
    }
}

enum weekDays
{
    Monday =7,
    Saturday,
    Friday
}


 struct X
{
    public X()
    {
        Console.WriteLine("Struct Constructor");
    }
}