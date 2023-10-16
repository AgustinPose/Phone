using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
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

        public void SendMessage()
        {
            
        }
    }
}
