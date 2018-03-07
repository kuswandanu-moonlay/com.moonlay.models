using System;

namespace Com.Moonlay.Models
{
    public interface IEntity
    {

    }
    public interface IEntity<out TKey> : IEntity
    {
        TKey Id { get; }
    }
}
