
int[,] arr = new int[2, 3];

for (int i = 0; i < arr.GetLength(1); i++)
{
    for (int j = 0; j < arr.GetLength(2); j++)
    {
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
public struct ValueView
{
    public int x;
    public int y;
    public static int XX = 10;   
    public ValueView(int x, int y)
    {
        this.x = x; 
        this.y = y;
    }

    public static void  View()
    {
        Console.WriteLine("Hello from Static");
    }

    struct Name
    {
        public int x;
        public int y;

        public Name()
        {
            Console.WriteLine("struct..");
        }
    }


    public class Hi <T> where T: struct, IEnumerable<T>
    {
        public T Data { get; set; }
    }
}