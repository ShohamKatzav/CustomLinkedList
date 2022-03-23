/*2.	Create a CustomLinkedList generic class that have: 
a.	Generic Node types First , Current , Last fields .
b.	Add method to add new generic value to the Node collection to the end of the collection
c.	GetEnumerator , GetEnumerableDESC methods to enable using foreach iterator for iterating the collection Node s in ascending , descending order.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class CustomLinkedList<T>
    {
        public Node<T>? First = null, Current = null, Last = null;

        public void Add(T item)
        {
            Node<T> add = new Node<T>(item);
            // No Items
            if (First == null)
            {
                First = add;
                Last = add;
            }
            // Theres already 1 item at least
            else
            {
                Last.Next = add;
                add.Previous = Last;
                Last = add;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Current = First;
            while (Current.Next != null)
            {
                Current = Current.Next;
                yield return Current.Previous.Value;
            }
            yield return Current.Value;

        }
        public IEnumerable<T> GetEnumerableDESC()
        {
            Current = Last;
            while (Current.Previous != null)
            {
                Current = Current.Previous;
                yield return Current.Next.Value;
            }
            yield return Current.Value;
        }

    }
}
