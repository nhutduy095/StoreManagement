using Application.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionItemMenu: EntityBase
    {

        public int Id { get; set; }
        public string MenuName { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        //public virtual ICollection<ItemMenuDetail> ItemMenuDetails { get; set; }
        //public virtual ICollection<OrderDetails> OrderDetails { get; set; }

    }
}
