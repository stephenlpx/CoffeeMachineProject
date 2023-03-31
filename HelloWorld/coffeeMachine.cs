using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

//TODO: make it so that the totalIngredient values change and stay at that value when the application is run again

namespace HelloWorld
{
    public class CoffeeMachine
    {
        private int totalWater = 300;
        private int totalMilk = 320;
        private int totalBeans = 500;
        private double totalSales = 0;

        //water, milk, beans, price
        public Dictionary<string, Tuple<int, int, int, double>> coffeeInfo;
        public bool canMakeCoffee;

        
        
        public CoffeeMachine()
        {
            coffeeInfo = new Dictionary<string, Tuple<int, int, int, double>>();
            coffeeInfo.Add("Cuppacino", Tuple.Create(100, 80, 50, 2.30));
            coffeeInfo.Add("Espresso", Tuple.Create(100, 0, 50, 2.80));
            coffeeInfo.Add("Latte", Tuple.Create(80, 120, 40, 3.20));
        }

        public Tuple<int, int, int, double> getCoffeeRequirements(string coffeeType)
        {
            Tuple<int, int, int, double> tuple = coffeeInfo[coffeeType];
            return tuple; 
        }

        public string coffeeDisplayInfo()
        {
            string displayInfo = "1. Cuppacino \n" + "2. Espresso \n" + "3. Latte";
            return displayInfo;
        }

        public string checkIngredients(int waterRequired, int milkRequired, int beansRequired)
        {
            if (waterRequired> this.totalWater || milkRequired > this.totalMilk || beansRequired > this.totalBeans)
            {
                this.canMakeCoffee = false;
                return "Not enough ingredients";
            }
            else
            {
                this.canMakeCoffee = true;
                return "There is sufficient ingredients for your coffee!";
            }
        }

        public void makeCoffee(string selectedCoffee)
        {
            
            var coffeeInfo = this.getCoffeeRequirements(selectedCoffee);
            int water = coffeeInfo.Item1;
            int milk = coffeeInfo.Item2;
            int beans = coffeeInfo.Item3;
            double total = coffeeInfo.Item4;

            totalWater -= water;
            totalMilk -= milk;
            totalBeans -= beans;
            totalSales += total;

        }

    }
}
