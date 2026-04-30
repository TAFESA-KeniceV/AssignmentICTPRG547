using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system.model
{

    public class DoublyLinkedList<T> : ICollection<T>
    {
        public DoublyLinkedListNode<T> Head
        {
            get; private set;
        }
        public DoublyLinkedListNode<T> Tail
        {
            get; private set;
        }
        public int Count
        {
            get; private set;
        }

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedListNode<T>(value));
        }
        public void AddFirst(DoublyLinkedListNode<T> node)
        {
            //save the head to temp
            DoublyLinkedListNode<T> temp = Head;
            //point to new node
            Head = node;
            //insert the prior head behind the new one
            Head.Next = temp;

            if (Count == 0)
            {
                //if it was empty the tail and head point to the same node
                Tail = Head;
            }
            else
            {
                //assign the before head's previous to the new head
                temp.Previous = Head;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedListNode<T>(value));
        }
        public void AddLast(DoublyLinkedListNode<T> node)
        {
            //if no nodes we add both head and tail
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                //adding to list
                Tail.Next = node;
                node.Previous = Tail;
            }
            //assign new tail
            Tail = node;
            Count++;
        }
        public void RemoveFirst()
        {
            Head = Head.Next;
            Count--;

            if (Count == 0)
            {
                //if there's no nodes left
                Tail = null;
            }
            else
            {
                //removing before head
                Head.Previous = null;
            }

        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    //if there's only one node to remove
                    Head = null;
                    Tail = null;
                }
                else
                {
                    //removing tail
                    Tail.Previous.Next = null;
                    //reassigning tail
                    Tail = Tail.Previous;
                }
                Count--;
            }

        }
        public void Add(T item)
        {
            AddFirst(item);
        }
        public bool Contains(T item)
        {
            DoublyLinkedListNode<T> current = Head;
            //while element in nodes
            while (current != null)
            {
                //tests equals
                if (current.Value.Equals(item))
                {
                    return true;
                }
                //iterates to next
                current = current.Next;
            }
            //end of linkedlist or empty linkedlist
            return false;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            //puting nodes in list???
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                //itterate to next
                current = current.Next;
            }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> previous = null;
            DoublyLinkedListNode<T> current = Head;
            //while there are node to remove
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    //if a to be removed is in the middle or end
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        //if at tthe end update tail
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        //if node to remove is first or only one node
                        RemoveFirst();
                    }
                    //a node had been removed
                    return true;
                }
                //itterating through
                previous = current;
                current = current.Next;
            }
            //no nodes to remove
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }





    }
}

