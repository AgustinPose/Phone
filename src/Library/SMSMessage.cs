using WhatsAppApiUCU;
using System;
namespace Library
{
    public class SMSMessage : Message
    {

        public SMSMessage(Contact contact, string text) :
            base(null, contact.Phone, text)
        {
            // Intencionalmente en blanco
        }
    }
}
