using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListImplementation;

namespace StackImplementation
{
    public class StackUsingLinkedList : IStack
    {
        public object Top { get; set; } //Node

        public int Size // returns List's size
        {
            get
            {
                return list.Size;
            }
        } 

        private LinkedList list; 

        public StackUsingLinkedList()
        {
            list = new LinkedList();
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
