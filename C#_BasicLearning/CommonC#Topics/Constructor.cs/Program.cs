
/*  Parameterized Constructor */
//Car car = new Car("BMW", 12123);
//Console.WriteLine(car.Model);
//Console.WriteLine(car.Price);

/*  Default Constructor */
//Car car = new Car();
//Console.WriteLine(car.Model);
//Console.WriteLine(car.Price);


/*  Parameterized Constructor */
//class Car
//{
//    public string Model;
//    public int Price;

//    public Car(string model, int price)
//    {
//        Model = model;
//        Price = price;
//    }
//}

/*  Default Constructor */
//class Car
//{
//    public string Model;
//    public int Price;
//}

/*  overLoad Constructor */

//Car car1 = new Car("BMW");
//Car car = new Car();


//class Car
//{
//    public string Model;
//    public int Price;
//    public Car()
//    {
//        Console.WriteLine("Car Constructor!");
//    }
//    public Car(string model)
//    {
//        Console.WriteLine("Overload constructor!");
//        Console.WriteLine(model);
//    }
//}


/*  Static Constructor */


//var b = new B();
//Car car1 = new Car();

//B b1 = new B();
////b1.Name = "Sohel";
////A a = new A("hello");
////a.Print();
//b1.Print();

//class A
//{
//    public string Name { get; set; }
//    public A(string name)
//    {
//        Name = name;
//    }
//    public void Print()
//    {
//        Console.WriteLine(Name);
//    }

//}

//class B : A
//{
//    public B(): base ("Hi")
//    {

//    }

//}




//class Car
//{
//    public string Model;
//    public int Price;
//    public static readonly int Id = 10;
//    static Car()
//    {
//        Console.WriteLine("Static Constructor - " + Id);
//    }
//    public Car()
//    {
//        Console.WriteLine("Default constructor!" + Id);
//    }
//}

//ChildClass childClass = new ChildClass("Sohel");
//childClass.GetName();
//ChildClass childClass1 = new ChildClass(childClass);
////ParentClass parentClass = new ParentClass("Hi", 23);
//class ParentClass
//{
//    public ParentClass()
//    {
//        Console.WriteLine("Parent Class.....");
//    }
//    public ParentClass(string Message)
//    {
//        Console.WriteLine(Message);
//    }
//    public ParentClass(string Message, int x)
//    {
//        Console.WriteLine(Message + " " + x);
//    }

//}
//class ChildClass : ParentClass
//{
//    public string Name { get; set; }
//    public ChildClass(string name) : base("hi ", 24)
//    {
//        Name = name;
//        Console.WriteLine(Name);
//    }
//    public ChildClass(ChildClass childClass)
//    {
//        Name = childClass.Name;
//        Console.WriteLine(Name);
//    }
//    public void GetName()
//    {
//        Console.WriteLine(Name);
//    }
//}


/*
A copy constructor is the third type among various types of constructors in C#. 
The member function initializes an object using another object of the same class. 
 */
//ChildClass childClass = new ChildClass("Sohel");
//childClass.GetName();
//ChildClass childClass1 = new ChildClass(childClass);
//childClass1.GetName();

//class ChildClass 
//{
//    public string Name { get; set; }
//    public ChildClass(string name)
//    {
//        Name = name;
//    }
//    public ChildClass(ChildClass childClass)
//    {
//        Name = childClass.Name = "Rakib";
//    }
//    public void GetName()
//    {
//        Console.WriteLine(Name);
//    }
//}
//Employee employee1 = new Employee("C1", 24);
//Employee employee2 = new Employee(employee1);
//Console.WriteLine(employee2.Details);

Manager.currentView = 100;
Console.WriteLine(Manager.VisitCount());

Manager manager = new Manager();
manager.FullInfo();

Manager manager1 = new Manager();
manager1.FullInfo();



//Manager manager = new Manager();
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public Employee(Employee employee) //Copy Constructor
    {
        Name=employee.Name;
        Age = employee.Age;
    }

    public string Details
    {
        get
        {
            return "The age of " + Name + " is " + Age.ToString();
        }
    }
}

public class Manager
{
    public static float _Pi;
    public string Name { get; set; }
    public Manager()
        :this("No parameter Value is provided")
    {
    }

    public Manager(string name)
    {
        Name = name;
    }

    static Manager()
    {
        Manager._Pi = 3.14F;
        Console.WriteLine(_Pi);
    }
    public void FullInfo()
    {
        Console.WriteLine(Name);
    }

    public static int currentView;
    public static int VisitCount()
    {
        return ++currentView;
    }
}