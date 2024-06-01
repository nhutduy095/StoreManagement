using Application.Base;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionItemImage : EntityBase
    {

        public int ImageId { get; set; }
        public string ImageURL { get; set; }
        public bool ImageBackground { get; set; }
        //[ForeignKey("Items")]
        public int ItemId { get; set; }
       // public virtual Items Item { get; set; }

    }
}
