using MediatR;
using Payments.Domain.Events;

namespace Payments.Application.EventHandlers
{
    public class PaymentCreatedEventHandler : INotificationHandler<PaymentCreatedEvent>
    {
        public PaymentCreatedEventHandler() { }

        // This method will handle the PaymentCreatedEvent
        public Task Handle(PaymentCreatedEvent paymentCreatedEvent, CancellationToken cancellationToken)
        {
            // Logic to handle the event, e.g., logging, updating a database, etc.
            Console.WriteLine($"Payment Created: {paymentCreatedEvent.PaymentId}, Amount: {paymentCreatedEvent.Amount}, Currency: {paymentCreatedEvent.Currency}, Status: {paymentCreatedEvent.Status}");
            return Task.CompletedTask;
        }
    }
}
