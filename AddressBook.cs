using System.Collections.Generic;

//HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
namespace AddressBook
{

    public class AddressBook 
    {
        //dictionary to store Contacts
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        //method for adding a contact
        public void AddContact(Contact newContact)
        {
            Contacts.Add(newContact.Email, newContact);
        }
        //method for using getbyemail userCollection method
        public Contact GetByEmail(string email)
        {
            //[] is the indexer
            return Contacts[email];
        }
    }
}

    
