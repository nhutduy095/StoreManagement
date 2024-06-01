using Application.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionCarts : EntityBase
    {
        public int CartId { get; set; }
        //[ForeignKey("Guest")]
        public int GuestId { get; set; }
        //[ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public string CustomerCd { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal TotalMoney { get; set; }
        //public virtual Customers Customer { get; set; }
        //public virtual Guest Guest { get; set; }
    }
}