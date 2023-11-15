/*
 * Създайте програма, която създава пица.

Направете два вида пица – вегетарианска и месна, посредством няколко стъпки:

1. Направете тeстото;
2. Добавете доматен сос;
3. Добавете сирене;  
4. Добавете добавките (в зависимост от вида пица: месна – шунка, бекон, пил. филе, салам; вегетарианска – домати, лук, спанак, рукола, царевица, чушка, грах).

Покажете на конзолата създадените пици.
 * */
using _2101681070_PizzaExam;


namespace _2101681070Menu
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Director director = new Director();
            Builder menu1Builder = new MeatPizzaBuilder();
            director.Construct(menu1Builder);
            menu1Builder.GetPizza().PrintInfo();

            Director director1 = new Director();
            Builder menu2Builder = new VegetarianPizzaBuilder();
            director.Construct(menu2Builder);
            menu2Builder.GetPizza().PrintInfo();
            Console.ReadKey();
        }
    }

}

