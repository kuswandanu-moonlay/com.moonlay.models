using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Moonlay.Models
{
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        public virtual TKey Id { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {

    }
}
