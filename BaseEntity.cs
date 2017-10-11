using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Moonlay.Models
{
    public abstract class BaseEntity : IEntity
    {
        public object Id { get; set; } 
    }

    public abstract class BaseEntity<TKey> : BaseEntity, IEntity<TKey>
    {
        public new TKey Id { get; set; }
    }
}
