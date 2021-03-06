﻿using System;
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
            if (IsEmpty())
                throw new IndexOutOfRangeException();
            else
            {
                string result = "";
                for (int i = (int)this.Top; i >= 0; i--)
                {
                    result += items_array[i].ToString() + " " ;
                }

                return result;
            }

        }

        public bool IsEmpty()
        {
            return Size == 0 && (int)Top == -1 ? true : false;
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return items_array[(int)Top];
            }
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Size--;
                object o = items_array[(int)Top];
                Top = (int)Top -1;
                return o;
            }
        }

        public void Push(object item)
        {
            if ((int)Top == items_array.Length-1)
            {
                throw new StackOverflowException();
            }
            else
            {
                Top = (int)Top + 1;
                items_array[(int)Top] = item;
                Size++;
            }
        }
    }
}
