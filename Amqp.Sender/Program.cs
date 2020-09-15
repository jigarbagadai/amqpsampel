using System;

namespace Amqp.Sender {
    class Program {
        static void Main(string[] args) {
            AWSMQ.SendMessage();
            AzureServiceBus.SendMessage();
        }
    }
}
