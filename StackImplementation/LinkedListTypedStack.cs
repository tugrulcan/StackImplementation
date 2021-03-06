﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListImplementation;

namespace StackImplementation
{
    public class LinkedListTypedStack : IStack
    {
        public object Top { get; set; } //Node

        public int Size // returns List's size
        {
            get
            {
                return list.Size;
            }
            set
            {

            }

        }


        private LinkedList list;

        public LinkedListTypedStack()
        {
            list = new LinkedList();
        }

        public bool IsEmpty()
        {
            return this.Size > 0 ? false : true;
        }

        public object Peek()
        {
            if (this.IsEmpty())
                throw new IndexOutOfRangeException();
            else
                return this.Top;
        }

        public object Pop()
        {
            if (this.IsEmpty())
                throw new IndexOutOfRangeException();
            else
            {
                object tempHead = this.list.Head;
                list.DeleteFirst();
                this.Top = list.Head;

                return tempHead;
            }
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
