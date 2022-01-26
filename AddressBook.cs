using System.Collections.Generic;

namespace TryCatch
{
  public class AddressBook
  {
    private Dictionary<string, Contact> _contactList { get; set; } = new Dictionary<string, Contact>();

    public void AddContact(Contact contactObj)
    {
      _contactList[contactObj.Email] = contactObj;
    }

    public Contact GetByEmail(string email)
    {
      return _contactList[email];
    }
  }
}