﻿using System;
using System.ComponentModel.DataAnnotations;
//My first change 2025
//My second change
namespace PartsUnlimited.Models
{
    //My first change
    public class CartItem : ILineItem
    {
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}