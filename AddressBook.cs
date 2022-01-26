using System;
using System.Collections.Generic;

namespace TryCatch
{
  public class AddressBook
  {
    private Dictionary<string, Contact> _contactList { get; set; } = new Dictionary<string, Contact>();

    public void AddContact(Contact contactObj)
    {
      try
      {
        _contactList.Add(contactObj.Email, contactObj);
        Console.WriteLine($"{contactObj.Email} has been added to the contact list.");
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine($"Couldn't Add {contactObj.Email} to the list. It has already been added to the list previously.");
      }
    }

    public Contact GetByEmail(string email)
    {
      return _contactList[email];
    }
  }
}