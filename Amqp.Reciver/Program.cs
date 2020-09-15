using System;

namespace Amqp.Reciver {
    class Program {
        static void Main(string[] args) {
            AWSMQ.ReadMessage();
            AzureServiceBus.ReadMessage();
        }
    }
}
