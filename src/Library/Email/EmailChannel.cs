using System.Globalization;
using System;
//using WhatsAppApiUCU;
//using EmailApiUCU; ;)
namespace Library
{
    public class EmailChannel : IMessageChannel
    {
        public void Send(Message message)
        {
            //     EmailApi email = new EmailApi();
            //     string toSend =  message.To;
            //     email.Send(toSend, message.Text);
            // 
        }
        public Message CreateEmail(Contact from, Contact to, string text)
        {
            return new EmailMessage(to, text);
        }

    }
}
