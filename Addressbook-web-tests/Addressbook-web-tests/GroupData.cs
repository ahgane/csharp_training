using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class GroupData
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
    }
}
