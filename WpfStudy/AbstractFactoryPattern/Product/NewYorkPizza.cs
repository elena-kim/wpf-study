﻿namespace AbstractFactoryPattern.Product
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class NewYorkPizza : IPizza
    {
        public void AddToppings(params string[] toppings)
        {
            Console.WriteLine("[NewYork Pizza] add toppings");

            int cnt = 1;
            foreach (var topping in toppings)
            {
                Console.WriteLine($"{cnt++}: {topping}");
            }
        }
    }
}