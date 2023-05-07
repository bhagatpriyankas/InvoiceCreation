﻿using System.ComponentModel.DataAnnotations;

namespace InvoiceCreation.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
}
