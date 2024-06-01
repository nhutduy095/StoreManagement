using Application.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionItemDetails : EntityBase
    {
        public int ItemDtId { get; set; }
        //[ForeignKey("Items")]
        public int ItemId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public virtual Items Item { get; set; }
    }
}

