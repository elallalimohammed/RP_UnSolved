using Pizza_StoreV8.Interfaces;
using Pizza_StoreV8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV8.PizzaCatalogs
{
    public class PizzaCatalog:IPizzaRepository
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
            if(!(pizzas.Keys.Contains(pizza.Id)))
                pizzas.Add(pizza.Id, pizza);
        }

        public Dictionary<int, Pizza> FilterPizza(string criteria)
        {
            Dictionary<int, Pizza> myPizzas = new Dictionary<int, Pizza>();
            if (criteria != null)
            {
                foreach (var p in pizzas.Values)
                {
                    if (p.Name.StartsWith(criteria))
                    {
                        myPizzas.Add(p.Id, p);
                    }
                }
            }        
            return myPizzas;
        }

        //A more performant  solution
        public Pizza GetPizza(int id)
        {
            return pizzas[id];
        }

        //Another solution less performant
        public Pizza GetPizza2(int id)
        {
            foreach (var p in pizzas)
            {
                if (p.Key == id)
                    return p.Value;
            }
            return new Pizza();
        }

        //A more performant version
        public void UpdatePizza(Pizza pizza)
        {
            if (pizza != null)
            {
                pizzas[pizza.Id] = pizza;
            }
        }

        //another version less performant
        public void UpdatePizza2(Pizza pizza)
        {
            foreach (var p in pizzas.Values)
            {
                if (p.Id == pizza.Id)
                {
                    p.Name = pizza.Name;
                    p.ImageName = pizza.ImageName;
                    p.Price = pizza.Price;
                    p.Description = pizza.Description;
                }
            }
        }

        // more performant solution
        public void DeletePizza(Pizza pizza)
        {
            if (pizza != null)
            {
                pizzas.Remove(pizza.Id);
            }
        }

        //less performant solution
        public void DeletePizza2(Pizza pizza)
        {
            foreach (var p in pizzas.Values)
            {
                if (p.Id == pizza.Id)
                {
                    pizzas.Remove(p.Id);
                }
            }
        }
    }
}
