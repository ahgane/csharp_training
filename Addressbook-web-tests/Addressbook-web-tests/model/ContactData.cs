using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string name;
        private string surname;
        private string company = "default";
        private string email = "default";
        //private string middlename = "default";
        //private string nickname = "default";
        //private string title = "default";
        //private string address = "default";
        //private string telephone_home = "default";
        //private string telephone_mobile = "default";
        //private string telephone_fax = "default";
        //private string email2 = "default";
        //private string email3 = "default";
        //private string homepage = "default";
        //private string birthday = "default";
        //private string anniversary = "default";
        //private string group = "";
        //private string secondary_address = "default";
        //private string secondary_address_home = "default";
        //private string notes = "default";

        public ContactData(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }
        public string Company
        {
            set
            {
                company = value;
            }
            get
            {
                return company;
            }
        }
        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (Name == other.Name)
            {
                return Surname == other.Surname;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return Name.CompareTo(other.Name);

        }

    }
}
