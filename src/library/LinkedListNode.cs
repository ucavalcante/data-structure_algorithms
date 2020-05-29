using System;

namespace LinkedList
{
    public class LinkedListNode
    {
        public Object Value { get; }
        public LinkedListNode Next { get; }
        public LinkedListNode(Object value, LinkedListNode next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
