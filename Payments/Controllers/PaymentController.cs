using MediatR;
using Microsoft.AspNetCore.Mvc;
using Payments.Domain.Entities;
using Payments.Domain.Events;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<PaymentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PaymentController>
        [HttpPost]
        public async Task PostAsync([FromBody] Payment value)
        {
            // Here you would typically add logic to handle the payment creation,
            // such as saving it to a database or publishing an event.
            // For example, you might want to publish a PaymentCreatedEvent.
            Console.WriteLine($"Payment Created: Id={value.Id}, Amount={value.Amount}, Currency={value.Currency}, Status={value.Status}");

            // You can also use MediatR to publish the event if you have it set up in your application.
            var paymentCreatedEvent = new PaymentCreatedEvent(value.Id, value.Amount, value.Currency, value.Status);
            await _mediator.Publish(paymentCreatedEvent);
        }

        // PUT api/<PaymentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaymentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
