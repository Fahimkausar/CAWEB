namespace SEm2Ca2
{
    internal class Program
    {
        const string Single = "", Return = "", Child = "", Student = "";
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Ballin Buses Main Menu");

            Console.WriteLine("1.Buy ticket");
            Console.WriteLine("2.Check in return ticket");
            Console.WriteLine("3.Print joruney report");
            Console.WriteLine("4.Exit");


            Console.WriteLine("Enter your option");
            option=int.Parse(Console.ReadLine());


            if (option == 1) 
            {
            
            
            
            }
        }
        static decimal CalculateTicketPrice(decimal basePrice, string ticketPrice)
        {
            //Declare variable
            double BusPrice = 10;


            double PricePerReturn;
            const double extra = 1.5;
            //Input
            Console.WriteLine("Pleae Enter your ticketPrice ");
            ticketPrice = Console.ReadLine();
            
            //Processing and Output

            PricePerReturn = BusPrice * extra;
            if (basePrice < 0 - 1)
            {
                Console.WriteLine($"Invalide Base Price");


            }
            if (ticketPrice == Single)
            {
                Console.WriteLine($"{BusPrice}");


            }
            else if (ticketPrice == Return)
            {
                Console.WriteLine($"{PricePerReturn}");

            }
            else
            {
                Console.WriteLine($"{BusPrice}");
            }
            Console.WriteLine($"10,{ticketPrice}== {BusPrice:c}");

            Console.WriteLine($"11,{ticketPrice}=={PricePerReturn}");
            Console.WriteLine($"-9,{ticketPrice}==");
            Console.WriteLine($"10,{ticketPrice}==");
            Console.WriteLine($"12,{ticketPrice}=={PricePerReturn}");

            return basePrice;
            static decimal ApplyDiscount(decimal price, string customerType)
        {
            const int AdultPrice = 10;
            const double DiscountChild = .50, DiscountStudent = .70;
            double total;
            string customerinfo;
            Console.WriteLine("What type of customer are you:");
            customerinfo = Console.ReadLine();

            if (customerinfo == Child)
            {
                total = AdultPrice * DiscountChild;

            }
            else if (customerinfo == Student)
            {
                total = AdultPrice * DiscountStudent;

            }
            else
            {
                total = 0;

            }
            Console.WriteLine($"ApplyDscount, {customerinfo}=={total}");
            return price;
        }
        static double BuyTicket() 
        {
            string ticketType, customerType;
            double Total, ticketPrice;

            Console.WriteLine("Please select your ticket type");
            ticketType= Console.ReadLine();

            Console.WriteLine("PLease select which type of customer are you:(adult,child,student,oap):");
            customerType= Console.ReadLine();

        }
    }
}