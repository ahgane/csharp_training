using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class Figure
    {
        private bool coloured = false;

        public bool Coloured
        {
            set
            {
                coloured = value;
            }
            get
            {
                return coloured;
            }
        }
    }
}
