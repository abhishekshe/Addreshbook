using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Management System");
            ContactPersonInformation contactPersonInformation = new ContactPersonInformation();
            contactPersonInformation.AddingContactDetails("Abhishek", "Narwariya", "a", "b", "c", 1, 2, "abhisheknarwariya813@gmail.com");
            contactPersonInformation.AddingContactDetails("anup", "lodhi", "a", "b", "d", 3, 5, "anuplodhi420@gmail.com");
            contactPersonInformation.DisplayContactDetails();
        }
    }
}