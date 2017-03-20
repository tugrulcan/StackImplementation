using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public interface IStack
    {
        object Top { get; set; }
        int Size { get; }
        void Push(object item);
        object Pop();
        object Peek();
        bool IsEmpty();

        string DisplayElements();
    }
}
