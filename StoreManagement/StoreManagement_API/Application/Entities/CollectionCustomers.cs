using Application.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionCustomers : EntityBase
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCd { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [NotMapped]
        public string PassWord { get; set; }
        //public virtual ICollection<Carts> Carts { get; set; }
        //public virtual ICollection<Orders> Orders { get; set; }
    }
}