namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket fTicket = new Ticket(5);
            Ticket lTicket = new Ticket(3);

            Ticket sumTicket = fTicket + lTicket;
            Ticket subTicket = lTicket - fTicket;
            Ticket mulTicket = fTicket * lTicket;   
            Ticket devTicket = fTicket / lTicket;
            Ticket oneInc = fTicket++;
            Ticket oneDec = fTicket--;

            Console.WriteLine("The summation of two ticket duration is - " 
                + sumTicket.DurationInHours + " and time is: " + sumTicket.CreationTime);

            Console.WriteLine("The subtraction of two ticket duration is - "
                + subTicket.DurationInHours + " and time is: " + subTicket.CreationTime);

            Console.WriteLine("The subtraction of two ticket duration is - "
                + mulTicket.DurationInHours + " and time is: " + mulTicket.CreationTime);

            Console.WriteLine("The subtraction of two ticket duration is - "
                + devTicket.DurationInHours + " and time is: " + devTicket.CreationTime);

            Console.WriteLine("The ++ : " + oneInc.DurationInHours);
            Console.WriteLine("The -- : " + oneDec.DurationInHours);
        }
    }
}
