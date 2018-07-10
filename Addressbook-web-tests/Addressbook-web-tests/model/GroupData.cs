using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    public  class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        private string name;
        private string header = "";
        private string footer = "";

        public GroupData (string name)
        {
            this.name = name;
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

        public string Header
        {
            set
            {
                header = value;
            }
            get
            {
                return header;
            }
        }
        public string Footer
        {
            set
            {
                footer = value;
            }
            get
            {
                return footer;
            }
        }

        public bool Equals(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            return Name == other.Name;

        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        
        public override string ToString()
        {
            return "name ="+Name;
        }

        public int CompareTo (GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return Name.CompareTo(other.Name);

        }
    }
}
