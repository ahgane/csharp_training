using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    class Square : Figure
    {
        private int size;

        public Square(int size)
        {
            this.size = size;
        }

        public int Size
        {
            set
            {
                size = value;
            }
            get
            {
                return size;
            }
        }
        
    }
}
