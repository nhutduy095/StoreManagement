﻿using Application.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionOrders : EntityBase
    {
        public int OrderId { get; set; }
        //[ForeignKey("Customers")]
        public int CustomerId { get; set; }
        //[ForeignKey("Guest")]
        public int GuestId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentMethod { get; set; }
        //public virtual Guest Guest { get; set; }
        //public virtual Customers Customers { get; set; }
        //public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}