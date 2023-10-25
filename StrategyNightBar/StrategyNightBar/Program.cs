namespace StrategyNightBar
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink1 = new Drink(5, 1);
            Drink drink2 = new Drink(10, 2);

            Order order = new Order();
            order.AddDrink(drink1);
            order.AddDrink(drink2);

            NightBarStrategy strategy1 = new DayStrategy();
            strategy1.Calculate(order.TotalAmount());

            NightBarStrategy strategy2 = new NormalStrategy();
            strategy2.Calculate(order.TotalAmount());

            Console.ReadKey();
        }
    }
}