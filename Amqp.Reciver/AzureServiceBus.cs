using System;
using System.Collections.Generic;
using System.Text;

namespace Amqp.Reciver {
    public class AzureServiceBus {
        public static string Namespace = "";
        public static string KeyName = "";
        public static string KeyValue = "";

        public static void ReadMessage() {
            Address address = new Address(Namespace, 5671, KeyName, KeyValue);

            Connection connection = new Connection(address);
            Session session = new Session(connection);
            ReceiverLink receiver = new ReceiverLink(session, "receiver-link", "q1");

            Console.WriteLine("Receiver connected to broker.");
            Message message = receiver.Receive(TimeSpan.FromMinutes(1));
            Console.WriteLine("Received " + message.Body.ToString());
            receiver.Accept(message);

            receiver.Close();
            session.Close();
            connection.Close();
        }
    }
}
