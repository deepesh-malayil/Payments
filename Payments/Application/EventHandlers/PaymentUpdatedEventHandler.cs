using MediatR;
using Payments.Domain.Events;

namespace Payments.Application.EventHandlers
{
    public class PaymentUpdatedEventHandler : INotificationHandler<PaymentUpdatedEvent>
    {
        public PaymentUpdatedEventHandler() { }
        // This method will handle the PaymentCreatedEvent
        public Task Handle(PaymentUpdatedEvent paymentUpdatedEvent, CancellationToken cancellationToken)
        {
            // Logic to handle the event, e.g., logging, updating a database, etc.
            Console.WriteLine($"Payment Updated: {paymentUpdatedEvent.PaymentId}, Amount: {paymentUpdatedEvent.Amount}, Currency: {paymentUpdatedEvent.Currency}, Status: {paymentUpdatedEvent.Status}");
            return Task.CompletedTask;
        }
    }
}
