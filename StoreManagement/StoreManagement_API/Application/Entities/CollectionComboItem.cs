using Application.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Entities
{
    public class CollectionComboItem : EntityBase
    {
        public int ComboDtlId { get; set; }
        //[ForeignKey("Combos")]
        public int ComboId { get; set; }
        //public Combos Combo { get; set; }

        //[ForeignKey("Items")]
        public int ItemId { get; set; }
        //public Items Item { get; set; }
    }
}