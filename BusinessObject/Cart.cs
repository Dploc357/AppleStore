using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataAccess.DataAccess
{
    public partial class Cart
    {
        [Key]
        public int CartId { get; set; }
        public string Username { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Totalprice { get; set; }
    }
}
