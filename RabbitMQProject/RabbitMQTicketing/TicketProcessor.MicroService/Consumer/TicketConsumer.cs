using MassTransit;
using Shared.Models.Model;
using System.Threading.Tasks;

namespace TicketProcessor.MicroService.Consumer
{
    public class TicketConsumer : IConsumer<Ticket>
    {
        public async Task Consume(ConsumeContext<Ticket> context)
        {
            var data = context.Message;
            //Validate the Ticket Data
            //Store to Database
            //Notify the user via Email / SMS

        }

    }
}
