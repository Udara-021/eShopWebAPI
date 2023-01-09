using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eShopWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public bool IsPopularProduct { get; set; }
        public int CategoryId { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }
        public ICollection <OrderDetail> OrderDetails { get; set; }
        public ICollection <ShoppingCartInfo> ShoppingCartInfom  { get; set; }
}
}
