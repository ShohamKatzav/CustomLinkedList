//1.	Create Node generic class that have Previous Node, Value generic, Next  Node fields.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class Node<T>
    {
        public T Value;
        public Node<T> Previous, Next;
        public Node(T value)
        { this.Value = value; }
        public override string ToString() 
        { 
            return Value.ToString(); 
        }
    }
}
