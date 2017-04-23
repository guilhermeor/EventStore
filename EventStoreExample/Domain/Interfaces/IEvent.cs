using System;

namespace Domain.Interfaces
{
    public interface IEvent
    {
        Guid Guid { get; }
    }
}