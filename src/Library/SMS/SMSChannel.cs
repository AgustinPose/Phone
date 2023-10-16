using System.Globalization;
using System;
//using WhatsAppApiUCU;
//using SMSApiUCU; ;)
namespace Library
{
    public class SMSChannel : IMessageChannel
    {
        public void Send(Message message)
        {
            //     SMSApi email = new SMSlApi();
            //     string toSend =  message.To;
            //     SMS.Send(toSend, message.Text);
            // 
        }
        public Message CreateSMS(Contact from, Contact to, string text)
        {
            return new SMSMessage(to, text);
        }

    }
}
