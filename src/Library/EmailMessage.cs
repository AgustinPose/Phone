using WhatsAppApiUCU;
using System;
namespace Library
{
    public class EmailMessage : Message
    {

        public EmailMessage(Contact contact, string text) :
            base(null, contact.Email, text)
        {
            // Intencionalmente en blanco
        }
    }
}
