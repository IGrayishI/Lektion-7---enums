namespace Lektion_7___enums
{

    //Enum practise
    enum Beverage
    {
        Coffee, 
        Tea,
        Soda,
        Juice,
        Water
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Awesome Vending Machine");
            Console.WriteLine("Which beverage do you fancy? (Coffee, Tea, Water, Soda, Juice)");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee);
                    break;
                case "tea":
                    Respond(Beverage.Tea);
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice": 
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("This machine dosnt have that drink");
                    break;
            }

        }

        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("Enjoy your fresh cup of coffee");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("Enjoy your fresh cup of tea");
                    break;
                case Beverage.Water:
                    Console.WriteLine("Enjoy your your sparkling water");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("Enjoy your Fanta");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("Enjot your freashly squeezed Orange Juice");
                    break;
            }
        }
    }
}