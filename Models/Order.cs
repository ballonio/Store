using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store.Models
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int Quanity { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
    }
}