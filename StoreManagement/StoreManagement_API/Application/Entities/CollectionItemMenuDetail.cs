using Application.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionItemMenuDetail : EntityBase
    {

        public int Id { get; set; }
        //[ForeignKey("Items")]
        public int ItemMenuId { get; set; }
        //[ForeignKey("ItemMenu")]
        public int ItemId { get; set; }
        //public virtual ItemMenu ItemMenu { get; set; }
        //public virtual Items Item { get; set; }

    }
}
