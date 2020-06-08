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
    }
}
