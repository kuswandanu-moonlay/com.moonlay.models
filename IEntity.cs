using System;

namespace Com.Moonlay.Models
{
    public interface IEntity
    {
        object Id { get; set; }
    }

    public interface IEntity<TKey> : IEntity
    {
        new TKey Id { get; set; }
    }

}
