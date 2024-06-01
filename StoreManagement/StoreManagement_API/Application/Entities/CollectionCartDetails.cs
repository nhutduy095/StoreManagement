using Application.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionCartDetails : EntityBase
    {
        public int CartDtlId { get; set; }
        //[ForeignKey("Items")]
        public int CartId { get; set; }
        //[ForeignKey("Carts")]
        public int ItemId { get; set; }
        [NotMapped]
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        //public virtual Carts Cart { get; set; }
        //public virtual Items Item { get; set; }
    }
}