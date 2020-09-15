using System;
using System.Collections.Generic;
using System.Text;

namespace Amqp.Sender {
    public class AzureServiceBus {
        public static string Namespace = "";
        public static string KeyName = "";
        public static string KeyValue = "";

        public static void SendMessage() {
            Address address = new Address(Namespace, 5671, KeyName, KeyValue);

            Connection connection = new Connection(address);
            Session session = new Session(connection);

            Message message = new Message("Hello AMQP!");
            SenderLink sender = new SenderLink(session, "sender-link", "q1");
            sender.Send(message);
            Console.WriteLine("Sent Hello AMQP!");

            sender.Close();
            session.Close();
            connection.Close();
        }
    }
}
