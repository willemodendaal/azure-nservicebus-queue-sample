# Azure+NService Service Bus Send/Receive

A bare bones C# solution that demonstrates how you can use Azure Queues together with NServiceBus to send a message from a client application, and to receive the message on the server.

The solution contains the following:

1. **Messages** - the assembly that contains the Message contract, called TheRequest.
2. **MessageSender** - a client console application that sends a message to the Azure Queue via NServiceBus.
3. **Receiver** - an NServiceBus.Host application that reads messages from the queue.
