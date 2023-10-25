using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNightBar
{
    public class Order          //Context
    {
        List<Drink> drinks;
        public Order()
        {
            this.drinks = new List<Drink>();
        }
        public void AddDrink(Drink drink)
        {
            drinks.Add(drink);
        }
        public void RemoveDrink(Drink drink)
        {
            drinks.Remove(drink);
        }
        public double TotalAmount()
        {
            double amount = 0;
            foreach (Drink drink in drinks)
            {
                amount += drink.price * drink.quantity;
            }
            return amount;
        }
        public void Calculate(NightBarStrategy strategy)
        {
            double amount = TotalAmount();
            strategy.Calculate(amount);
        }
    }
}
