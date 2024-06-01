using Application.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    public class CollectionGuest : EntityBase
    {
        public int GuestId { get; set; }
        public string GuestLastName { get; set; }
        public string GuestFirsttName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        //public virtual ICollection<Carts> Carts { get; set; }
        //public virtual ICollection<Orders> Orders { get; set; }
    }
}