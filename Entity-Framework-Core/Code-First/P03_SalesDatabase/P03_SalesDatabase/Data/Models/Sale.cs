﻿using System;
using System.ComponentModel.DataAnnotations;

namespace P03_SalesDatabase.Data.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }


        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        [Required]
        public int StoreId { get; set; }
        public Store Store { get; set; }
        /*⦁	SaleId
⦁	Date
⦁	Product
⦁	Customer
⦁	Store
*/
    }
}