using System;
using System.Collections.Generic;
using System.Text;

namespace Amqp.Sender {
    public class AWSMQ {
        public static void SendMessage() {
            Address address = new Address("");

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
