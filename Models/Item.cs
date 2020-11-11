using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store.Models
{
    [Table("Item")]
    public class Item
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
    }
}