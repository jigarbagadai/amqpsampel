using System;
using System.Collections.Generic;
using System.Text;

namespace Amqp.Reciver {
    public class AWSMQ {
        public static void ReadMessage() {
            Address address = new Address("");

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
