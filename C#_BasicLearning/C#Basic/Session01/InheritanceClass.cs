//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class A
//{
//    private int _value = 10;
//    internal int _count = 10;
//    public class B : A
//    {
//        public int GetValue()
//        {
//            return _value;
//        }
//    }
//}
//public class C : A
//{
//    public int GetValue()
//    {
//        return _count; //
//        //return _value; ///Hare the _value is not accessible as it is not a nested class of Class A.
//    }
//}

//public abstract class A
//{
//    public abstract void Methoda();
//}
//public class B : A
//{
//    public override void Methoda()
//    {
//        Console.WriteLine("Hello! from override method");
//    }
//}

//public class Automobile
//{
//    public Automobile(string make, string model, int year)
//    {
//        if (make == null)
//        {
//            throw new ArgumentNullException(nameof(make), "The make can not be null");
//        }
//        else if (string.IsNullOrWhiteSpace(make))
//        {
//            throw new ArgumentException(nameof(make), "Make can not be empty");
//        }
//        Make = make;

//        if (model == null)
//            throw new ArgumentNullException(nameof(model), "The model cannot be null.");
//        else if (string.IsNullOrWhiteSpace(model))
//            throw new ArgumentException("model cannot be an empty string or have space characters only.");
//        Model = model;

//        if (year < 1857 || year > DateTime.Now.Year + 2)
//            throw new ArgumentException("The year is out of range.");
//        Year = year;
//    }

//        public string Make { get; }
//        public string Model { get; }
//        public int Year { get; }
//    public override string ToString()
//    {
//        return $"{Year} {Make} {Model}";
//    }
//}


//public enum  PublicationType { Misc, Book, Magazine, Article}

//public abstract class Publication
//{
//    private bool _published = false;
//    private DateTime _datePublished;
//    private int _totalPages;

//    public string Publisher { get; }
//    public string Title { get; }
//    public PublicationType Type { get; }
//    public string? CopyrightName { get; private set; }

//    public int CopyrightDate { get; private set; }

//    public int Pages
//    {
//        get { return _totalPages; }
//        set
//        {
//            if (value <= 0)
//            {
//                throw new ArgumentOutOfRangeException(nameof(value), "Number of page can not be zero or negative");
//            }
//            _totalPages = value;
//        }
//    }
//    public string GetPublicationDate()
//    {
//        if (!_published)
//        {
//            return "NYP";
//        }
//        else
//        {
//            return _datePublished .ToString("D");
//        }
//    }
//    public Publication(bool published, DateTime datePublished, int totalPages)
//    {
//        _published = published;
//        _datePublished = datePublished;
//        _totalPages = totalPages;
//    }
//    public void Publish(DateTime datePublished)
//    {
//        _published = true;
//        _datePublished = datePublished;
//    }
//    public void Copyright(string copyrightName, int copyrightDate)
//    {
//        if (string.IsNullOrWhiteSpace(copyrightName))
//            throw new ArgumentException("The name of the copyright holder is required.");
//        CopyrightName = copyrightName;

//        int currentYear = DateTime.Now.Year;
//        if (copyrightDate < currentYear - 10 || copyrightDate > currentYear + 2)
//            throw new ArgumentOutOfRangeException($"The copyright year must be between {currentYear - 10} and {currentYear + 1}");
//        CopyrightDate = copyrightDate;
//    }

//}
////public class InheritanceClass
////{
////    public static void Main(string[] args)
////    {
////        A b = new B();
////        b.Methoda();
////        Automobile automobile = new Automobile("BMW", "BB04", 2022);
////        Console.WriteLine(automobile);
////    }
////}

//Multiple Inheritance using Interface

using System.Reflection.Metadata.Ecma335;

///
//Rectangle rectangle = new Rectangle(2, 4, "Red");
//var getNewRectangle = rectangle.GetArea();
//Console.WriteLine("The area of a new Rectangle is: " +  getNewRectangle);
//Console.WriteLine("Color of rectangle: " + rectangle.GetColor());

//Person1 person = new Person1();



interface IShape
{
    double GetArea();
}
interface IColor
{
    public string GetColor();
}

class Rectangle: IShape, IColor
{
    private double length;
    private double width;
    private string color;

    public Rectangle(double length, double width, string color)
    {
        this.length = length;
        this.width = width;
        this.color = color;
    }

    public double GetArea()
    {
        return length * width;
    }
    public string GetColor()
    {
        return color;
    }
}

//interface GG1
//{
//    public void g1();
//}


//class A : GG1
//{
//    public void g1()
//    {
        
//    }
//}

//interface GG2
//{
//    public void g2();
//}

//class B : GG2
//{
//    public void g2() 
//    {

//    }
//}

//class C : A, B
//{

//}

//class Person
//{
//    protected string name;
//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//}
//class Employee : Person
//{
//   public string EmployeeName()
//    {
//        return name;
//    }
//}


class Person
{
    public Person()
    {
        Console.WriteLine("Person Constructor");
    }
}
class Person1 : Person
{
    public Person1()
    {
        Console.WriteLine("Person1 Constructor");
    }
}