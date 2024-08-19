
//StackImplement stackImplement = new StackImplement();

//bool exit = false;
//while (!exit)
//{
//    Console.WriteLine("Push: 1");
//    Console.WriteLine("Pop: 2");
//    Console.WriteLine("Top : 3");
//    Console.WriteLine("Size: 4");
//    Console.WriteLine("Stack List: 5");
//    Console.WriteLine("Enter '6' to Exit the program");

//    int read = Convert.ToInt32(Console.ReadLine());

//    switch (read)
//    {
//        case 1:
//            {
//                Console.WriteLine("Enter the Element");
//                int arrayElement = Convert.ToInt32(Console.ReadLine());
//                stackImplement.Push(arrayElement);

//                break;
//            }
//        case 2:
//            {
//                stackImplement.Pop();
//                break;
//            }
//        case 3:
//            {
//                Console.WriteLine(stackImplement.Top());
//                break;
//            }
//        case 4:
//            {
//                Console.WriteLine(stackImplement.Size());
//                break;
//            }
//        case 5:
//            {
//                stackImplement.ArrayLoad();
//                break;
//            }
//        case 6:
//            exit = true;
//            break;
//    }
//}


//struct StackImplement
//{
//    private int[] Arr;
//    int Sz;
//    private int arrayCapacity;
//    public StackImplement()
//    {
//        Sz = 0;
//        arrayCapacity = 3;
//        Arr = new int[arrayCapacity];
//    }
//    public void Push(int x)
//    {
//        if (Sz == arrayCapacity)
//        {
//            arrayCapacity = arrayCapacity * 2;
//            Array.Resize(ref Arr, arrayCapacity);
//        }
//        Arr[Sz] = x;
//        Sz++;
//    }
//    public void Pop()
//    {
//        if (Sz > 0)
//        {
//            Sz--;
//        }
//        else
//        {
//            Console.WriteLine("Stack is empty!");
//        }
//    }
//    public int Top()
//    {
//        if (Sz > 0)
//        {
//            return Arr[Sz - 1];
//        }
//        else
//        {
//            Console.WriteLine("Stack is empty Now.");
//            return -1;
//        }
//    }
//    public int Size()
//    {
//        return Sz;
//    }
//    public void ArrayLoad()
//    {
//        for (int i = 0; i < Sz; i++)
//        {
//            Console.WriteLine(Arr[i]);
//        }
//    }
//}