using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Pizza_StoreV7.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "Name of the pizza can not be longer than 18 chars")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Price required")]
        [Range(typeof(decimal), "50", "100",
        ErrorMessage = "Value for the price should be between50 and 100 ")]

        public decimal Price { get; set; }
        public string ImageName { get; set; }
    }
}
