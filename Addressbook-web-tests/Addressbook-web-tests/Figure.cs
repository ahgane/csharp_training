using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_web_tests
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
