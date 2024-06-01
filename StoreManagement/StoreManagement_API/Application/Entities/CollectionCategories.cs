using Application.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities
{
    public class CollectionCategories : EntityBase
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //public virtual ICollection<Items> Items { get; set; }
    }
}
