using System;
class Program {
    static void Main(string[] args) {
        int dayofweek = 0;
        int timeofday = 0;
        int breakfastset = 5;
        int weekendset = 2;
        int coffee = 3;

        while (true){
            Console.Write("Order Day of Week 1-7! : ");
            dayofweek = int.Parse(Console.ReadLine());
            Console.Write("Order Time Of Day 8-18! : ");
            timeofday = int.Parse(Console.ReadLine());
            Console.Write("Breakfast Set ,Weekend Set ,Coffee , End : ");
            string GrabOrder = Console.ReadLine();

            if (GrabOrder == "End"){
                Console.WriteLine("Thanks for your purchase order");
                break;                
            }

            switch (GrabOrder){
                case "Breakfast Set":
                    if (timeofday > 11 || breakfastset == 0){
                        Console.WriteLine(timeofday > 11 ? "Sorry your order is not available now" : "Sorry your order is out of stock");
                        break;
                    }
                    breakfastset--;
                    Console.WriteLine("order was successful! : Breakfast Set");
                    break;

                case "Weekend Set":
                    if (dayofweek <= 5 || weekendset == 0){
                        Console.WriteLine(dayofweek <= 5 ? "Sorry your order is not available now" : "Sorry your order is out of stock!");
                        break;
                    }
                    weekendset--;
                    Console.WriteLine("order was successful! : Weekend Set");
                    break;

                case "Coffee":
                    if (coffee == 0){
                        Console.WriteLine("Sorry your order is out of stock!");
                        break;
                    }
                    coffee--;
                    Console.WriteLine("order was successful! : Coffee!");
                    break;

                default:
                    Console.WriteLine("Please enter a valid menu!");
                    break;
            }
        }
    }
}
