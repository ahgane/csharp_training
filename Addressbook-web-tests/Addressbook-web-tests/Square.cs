using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook_web_tests
{
    class Square
    {
        private int size;

        public Square(int size)
        {
            this.size = size;
        }

        public int Size
        {
            Set
            {
                size = Value;
            }
            Get
            {
                return size;
            }
        }

        public int GetSize ()
        {
            return size;
        }

        public void SetSize(int size)
        {
            this.size = size;
        }
    }
}
