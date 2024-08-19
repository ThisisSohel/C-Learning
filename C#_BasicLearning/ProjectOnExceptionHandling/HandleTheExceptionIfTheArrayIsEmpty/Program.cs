namespace HandleTheExceptionIfTheArrayIsEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0] ;

            try
            {
                CalculateAverage(arr);
            }
            catch(EmptyArrayException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void CalculateAverage(int[] arr)
        {
            if(arr.Length == 0)
            {
                throw new EmptyArrayException("Array can not be empty");
            }
            else
            {
                int sum = 0;
                int average = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                average = sum / arr.Length;
                Console.WriteLine(average);
            }
        }

        class EmptyArrayException: Exception
        {
            public EmptyArrayException(string message) : base(message) 
            { 
            }
        }
    }
}
