using MediatR;

namespace Payments.Domain.Contracts
{
    public interface IDomainEvent : INotification
    {
        /// <summary>
        /// Gets the unique identifier for the event.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the timestamp when the event occurred.
        /// </summary>
        DateTime OccurredOn { get; }

        /// <summary>
        /// Gets the type of the event.
        /// </summary>
        string EventType { get; }
        
        /// <summary>
        /// Gets the version of the event.
        /// </summary>
        int Version { get; }
    }
}
