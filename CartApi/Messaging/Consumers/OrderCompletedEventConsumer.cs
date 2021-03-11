using CartApi.Models;
using Common.Messaging;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartApi.Messaging.Consumers
{
    public class OrderCompletedEventConsumer : IConsumer<OrderCompletedEvent>
    {
        private readonly ICartRepositary _repository;
       
        public OrderCompletedEventConsumer(ICartRepositary repository)
        {
            _repository = repository;
            
        }

        public async Task Consume(ConsumeContext<OrderCompletedEvent> context)
        {
           
            await _repository.DeleteCartAsync(context.Message.BuyerId);

        }
    }
}
