using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iShop.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int QuantityInStock { get; set; }

        public ICollection<CategoryToProduct> CategoryToProducts { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
