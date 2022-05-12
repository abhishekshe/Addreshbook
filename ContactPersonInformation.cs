using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class ContactPersonInformation
    {
        List<ContactDetails> contactDetailsList;
        private readonly NLog nLog = new NLog();

        public ContactPersonInformation()
        {
            contactDetailsList = new List<ContactDetails>();
        }
        public void AddingContactDetails()
        {
            while (true)
            {
            Repeat: Console.WriteLine("Please enter first name, last name, address, city, state, zip, phoneno and email");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    nLog.LogInfo("No more contact details have been entered");
                    break;
                }
                string lastName = Console.ReadLine();
                string address = Console.ReadLine();
                string city = Console.ReadLine();
                string state = Console.ReadLine();
                int zip = Convert.ToInt32(Console.ReadLine());
                double phoneNo = Convert.ToDouble(Console.ReadLine());
                if (phoneNo <= 200000)
                {
                    //Console.WriteLine("Please enter a valid Phone no.");
                    nLog.LogError("Entered Wrong Phone no. : AdditionContactDetails()");
                    Console.WriteLine("Wrong phone details entered, please enter your details again");
                    goto Repeat;
                }
                string eMail = Console.ReadLine();

                ContactDetails contactDetails = new ContactDetails(firstName, lastName, address, city, state, zip, phoneNo, eMail);
                if (contactDetailsList.Contains(contactDetails))
                {
                    nLog.LogError("Contact details have already been entered");
                    Console.WriteLine("Contact details have already been entered\n please add new contact details");
                    goto Repeat;

                }
                else
                {
                    contactDetailsList.Add(contactDetails);
                    nLog.LogDebug("Contact Details Addition Successful: AddingContactDetails()");
                }
            }


        }
        public void DisplayContactDetails()
        {
            foreach (ContactDetails contactPerson in contactDetailsList)
            {
                Console.WriteLine($"First Name : {contactPerson.firstName} || Last Name: {contactPerson.lastName} || Address: {contactPerson.address} || City: {contactPerson.city} || State: {contactPerson.state}|| zip: {contactPerson.zip} || Phone No: {contactPerson.phoneNo} || eMail: {contactPerson.eMail}");
            }
            nLog.LogDebug("Displaying Contact Details Successful :DisplayingContactDetails()");
        }
    }

}