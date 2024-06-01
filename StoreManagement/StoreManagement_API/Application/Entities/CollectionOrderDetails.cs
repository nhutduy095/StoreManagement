using Application.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionOrderDetails : EntityBase
    {
        public int OrderDtlId { get; set; }
        //[ForeignKey("Orders")]
        public int OrderId { get; set; }
        //[ForeignKey("ItemMenu")]
        public int ItemMenuId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        //public virtual Orders Order { get; set; }
        //public virtual ItemMenu ItemMenu { get; set; }
    }
}