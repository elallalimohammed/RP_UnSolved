using Pizza_StoreV9.Models;
using Pizza_StoreV9.Interfaces;
using Pizza_StoreV9.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV9.Services
{
    public class PizzaJson : IPizzaRepository
    {
        string JsonFileName = @"C:\Users\EASJ\Source\Repos\RazorPages_Exercises_Solutions\RazorPages_Exercises\Pizza_StoreV9\Data\JsonPizzas.json";

        public void AddPizza(Pizza pizza)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
            pizzas.Add(pizza.Id, pizza);
            JsonFileWritter.WriteToJson(pizzas,JsonFileName);
        }

        public Dictionary<int, Pizza> AllPizzas()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }
        public Dictionary<int, Pizza> FilterPizza(string criteria)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
                Dictionary<int, Pizza> filteredPizzas = new Dictionary<int, Pizza>();
                foreach (var p in pizzas.Values)
                {
                    if (p.Name.StartsWith(criteria))
                    {
                        filteredPizzas.Add(p.Id, p);
                    }
                }
                return filteredPizzas;
            
        }
        public Pizza GetPizza(int id)
        {
            // not implemented yet;
            return new Pizza();
        }
        public void UpdatePizza(Pizza pizza)
        {
            // not implemented yet
        }

        public void DeletePizza(Pizza pizza)
        {
            // not implemented;
        }

    }
}
