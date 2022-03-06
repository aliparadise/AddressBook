using System;
using System.Collections.Generic;

namespace AddressBook
{

    class Program
    {
    /*
        1. Add the required classes (addressbook and contacts) to make the following code compile.
        HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.

        2. Run the program and observe the exception.

        3. Add try/catch blocks in the appropriate locations to prevent the program from crashing
            Print meaningful error messages in the catch blocks.
    */

        static void Main(string[] args)
        {
        // Create a few contacts
            Contact bob = new Contact() {
                FirstName = "Bob", LastName = "Smith",
                Email = "bob.smith@email.com",
                Address = "100 Some Ln, Testville, TN 11111"
            };
            Contact sue = new Contact() {
                FirstName = "Sue", LastName = "Jones",
                Email = "sue.jones@email.com",
                Address = "322 Hard Way, Testville, TN 11111"
            };
            Contact juan = new Contact() {
                FirstName = "Juan", LastName = "Lopez",
                Email = "juan.lopez@email.com",
                Address = "888 Easy St, Testville, TN 11111"
            };


        // Create an AddressBook and add some contacts to it
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(bob);
            addressBook.AddContact(sue);
            addressBook.AddContact(juan);

        // Try to addd a contact a second time
        //added a try/catch here to create an exception for adding an already existing key
        try
        {
            addressBook.AddContact(sue);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("You have a duplicate contact.");
        }


        // Create a list of emails that match our Contacts
            List<string> emails = new List<string>() {
                "sue.jones@email.com",
                "juan.lopez@email.com",
                "bob.smith@email.com",
            };

        // Insert an email that does NOT match a Contact
        emails.Insert(1, "jane.doe@email.com");


        //  Search the AddressBook by email and print the information about each Contact
        //added try/catch inside foreach loop to catch keynotfound exception and continue looping
            foreach (string email in emails)
            {
                try
                {
                    Contact contact = addressBook.GetByEmail(email);
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"Name: {contact.FullName}");
                    Console.WriteLine($"Email: {contact.Email}");
                    Console.WriteLine($"Address: {contact.Address}");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"This {email} was not found in the list of contacts.");
                }
            }
        }
    }
}
