using System;
using library;

namespace double_linked_list
{
    public class DoubleLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void Append(Object value)
        {
            if (value is null)
            {
                throw new ArgumentNullException();
            }
            var newNode = new Node(value);
            if (Head is null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }
        }
        public void Delete(Object value)
        {
            if (value is null)
            {
                throw new ArgumentNullException();
            }
            if (Head.Value.Equals(value))
            {
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                    Head.Previous = null;
                }
                return;
            }
            var currentNode = Head.Next;
            while (currentNode != null && !currentNode.Value.Equals(value))
            {
                currentNode = currentNode.Next;
            }
            if (currentNode.Equals(Tail))
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                currentNode.Previous.Next = currentNode.Next;
                currentNode.Next.Previous = currentNode.Previous;
            }

        }
    }
}
