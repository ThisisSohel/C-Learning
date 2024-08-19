
Circle circle = new Circle(2);
Console.WriteLine(circle.CalculateArea());
Circle circle2 = new Circle(2);
Console.WriteLine(circle.CalculateArea());

Circle circle3 = new Circle(3);

class Circle
{
   public static float _PI = 3.14f;
   public static int _Radious;

    public Circle(int Radius)
    {
        _Radious = Radius;
    }
    public float CalculateArea()
    {
        return _PI * _Radious * _Radious;
    }
}
