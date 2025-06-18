using MediatR;
using Payments.Domain.Events;

namespace Payments.Application.EventHandlers
{
    public class PaymentDeletedEventHandler : INotificationHandler<PaymentDeletedEvent>
    {
        public PaymentDeletedEventHandler() { }

        // This method will handle the PaymentCreatedEvent
        public Task Handle(PaymentDeletedEvent paymentDeletedEvent, CancellationToken cancellationToken)
        {
            // Logic to handle the event, e.g., logging, updating a database, etc.
            Console.WriteLine($"Payment Deleted: {paymentDeletedEvent.PaymentId}");
            return Task.CompletedTask;
        }
    }
}
