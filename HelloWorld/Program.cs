using System;
using System.Runtime.CompilerServices;

namespace HelloWorld

//TODO
// put this in a loop so the customer can make another order if they want to 
// can maybe output the customer and the coffee they ordered to a csv file which can be used to analyse/query
{
    class Hello
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Stephen's Coffee Machine");
            Console.WriteLine("========== \n");
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();


            Person person = new Person(firstName: firstName, lastName: lastName);
            string fullName = person.FullName();
            CoffeeMachine machine = new CoffeeMachine();


            Console.WriteLine("\nWelcome " + fullName + ". Which coffee would you like today?\n" + machine.coffeeDisplayInfo());
            string coffeeType = Console.ReadLine();
            var coffeeRequirements = machine.getCoffeeRequirements(coffeeType);

            string canMakeCoffee = machine.checkIngredients(coffeeRequirements.Item1, coffeeRequirements.Item2, coffeeRequirements.Item3);
            Console.WriteLine(canMakeCoffee);

            if (machine.canMakeCoffee)
            {
                double coffeePrice = coffeeRequirements.Item4;
                Console.WriteLine("Your Total is: ${0}", coffeePrice);
                Console.WriteLine("Enter Money: ");
                double paidAmount = double.Parse(Console.ReadLine());
                if (paidAmount < coffeePrice)
                {
                    Console.WriteLine("That is not enough money, returning your money.");

                }else
                {
                    machine.makeCoffee(coffeeType);
                    Console.WriteLine("Thank you for your purchase!");
                    
                }
            }

        }

    }

}
