using System.Collections.Generic;

namespace Library
{
    public class Phonebook 
    {
        private List<Contact> persons;
        private WhatsAppChannel messageChannel;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
            messageChannel = new WhatsAppChannel();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public void AddContact(string name, string phone, string email)
        {
            // Por Creator
            Contact person = new Contact(name);
            person.Phone = phone;
            person.Email = email;
            
            this.persons.Add(person);
        }

        public void RemoveContact(string name,string phone, string email)
        {
            // Esta podría ser una posible implementación para el método
            foreach(Contact person in this.persons)
            {
                if (person.Name.Equals(name) && person.Phone.Equals(phone) && person.Email.Equals(email))
                {
                    persons.Remove(person);
                }
            }
        }

        // Se supone que SendMessage recibe el nombre del contacto y el texto a enviar
        public void SendMessage(string to, string text)
        {
            var contactoToSend = Search(new string[] {to});
            foreach(Contact contact in contactoToSend)
            {
                Message message = messageChannel.CreateMessage(this.Owner, contact, text);
                messageChannel.Send(message);
            }
        }

    }
}
