//var result = Calculator.Sum(2 , 3);
//Calculator.StoreResult(result);
//var calType = Calculator.type;
//Console.WriteLine(calType);

//StopWatch stopWatch = new StopWatch();
//StopWatch stopWatch1 = new StopWatch();
//Console.WriteLine(StopWatch.NoOfIntances);
//StopWatch stopWatch2 = new StopWatch();
//StopWatch stopWatch3 = new StopWatch();
//Console.WriteLine(StopWatch.NoOfIntances);

//StopWatch.DataView();
//StopWatch stopWatch = new StopWatch();
//StopWatch.DataView();

public static class Calculator
{
    private static int resultStorage = 0;
    public static string type = "Arithmatic";

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    public static void StoreResult (int result)
    {
        resultStorage = result;
        Console.WriteLine(resultStorage);
    }
}

//public class StopWatch
//{
//    public static int NoOfIntances = 0;
//    public StopWatch()
//    {
//        NoOfIntances++;
//    } 
//}
public class StopWatch
{
    static StopWatch()
    {
        Console.WriteLine("Static Con....");
    }
    public StopWatch()
    {
        Console.WriteLine("Instance Con....");
    }
    public static void DataView() 
    {
        Console.WriteLine("Data view....");
    }
}
