
namespace Receiver
{
    using NServiceBus;

    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence>();
            configuration.UseTransport<AzureServiceBusTransport>();
            configuration.EndpointName("queue1"); //This can also be done by a few other means: See http://docs.particular.net/nservicebus/messaging/specify-input-queue-name
            configuration.ScaleOut().UseSingleBrokerQueue(); //Important, otherwise NServiceBus appends machine name at end of endpoint name. Only an issue if clients need to use callbacks.

        }
    }
}
