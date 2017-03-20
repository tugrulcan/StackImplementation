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
            return this.Size > 0 ? false : true;
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
            int item_i = Convert.ToInt32(item);
            list.InsertFirst(item_i);
            this.Top = list.GetElement(0);
        }

        public string DisplayElements()
        {
            return list.DisplayElements();
        }
    }
}
