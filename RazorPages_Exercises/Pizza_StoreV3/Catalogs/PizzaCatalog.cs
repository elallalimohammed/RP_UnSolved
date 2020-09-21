using Pizza_StoreV3.Models;
using Pizza_StoreV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV3.PizzaCatalogs
{
    public class PizzaCatalog
    {
        private Dictionary<int, Pizza> pizzas { get; }
        public PizzaCatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
            pizzas.Add(1, new Pizza() { Id = 1, Name = "Cheese_pizza", Description = " Maden of cheese", Price = 98 , ImageName= "Cheese_pizza.jfif" });
            pizzas.Add(2, new Pizza() { Id = 2, Name = "Bufalla_pizza", Description = " Maden of bufalla", Price = 59, ImageName = "Bufalla_pizza.jfif" });
            pizzas.Add(3, new Pizza() { Id = 3, Name = "Chicken_pizza", Description = " Maden of chicken", Price = 120, ImageName = "Chicken_pizza.jfif" });
            pizzas.Add(4, new Pizza() { Id = 4, Name = "Mozzarella_pizza", Description = " Maden of mozzarella", Price = 77, ImageName = "Mozzarella_pizza.jfif" });
            pizzas.Add(5, new Pizza() { Id = 5, Name = "Vegetable_pizza", Description = " Maden of vegetars", Price = 88, ImageName = "Vegetable_pizza.jfif" });
        }

        public Dictionary<int,Pizza> AllPizzas()
        {
            return pizzas;
        }
        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza.Id, pizza);
        }
    }
}
