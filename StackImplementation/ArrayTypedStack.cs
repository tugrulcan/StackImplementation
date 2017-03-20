using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class ArrayTypedStack : IStack
    {

        public int Size { get; set; }
        private object[] items_array;

        public object Top { get; set; }
        public ArrayTypedStack(int array_size)
        {
            this.Top = -1;
            this.Size = 0;
            items_array = new object[array_size];

        }

        public string DisplayElements()
        {
            if (this.IsEmpty())
                throw new IndexOutOfRangeException();
            else
            {
                string result = "";
                for (int i = (int)this.Top; i > 0; i--)
                {
                    result += items_array[i].ToString() + " " ;
                }

                return result;
            }

        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public object Peek()
        {
            throw new NotImplementedException();
        }

        public object Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(object item)
        {
            throw new NotImplementedException();
        }
    }
}
