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
        public void AddingContactDetails(string firstName, string lastName, string address, string city, string state, int zip, double phoneNo, string eMail)
        {
            if (phoneNo <= 200000)
            {
               
                nLog.LogWarn("Entered Wrong Phone no. : AdditionContactDetails()");
            }
            ContactDetails contactDetails = new ContactDetails(firstName, lastName, address, city, state, zip, phoneNo, eMail);
            if (contactDetailsList.Contains(contactDetails))
            {
                nLog.LogError("Contact details have already been entered");
                Console.WriteLine("Contact details have already been entered\n please add new contact details");

            }
            else
            {
                contactDetailsList.Add(contactDetails);
                nLog.LogInfo("Contact Details Addition Successful: AddingContactDetails()");
            }


        }
        public void DisplayContactDetails()
        {
            foreach (ContactDetails contactPerson in contactDetailsList)
            {
                Console.WriteLine($"First Name : {contactPerson.firstName} || Last Name: {contactPerson.lastName} || Address: {contactPerson.address} || City: {contactPerson.city} || State: {contactPerson.state}|| zip: {contactPerson.zip} || Phone No: {contactPerson.phoneNo} || eMail: {contactPerson.eMail}");

            }
        }
    }

}