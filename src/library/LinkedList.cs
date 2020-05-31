using System;

namespace LinkedListLibrary
{
    public class LinkedList
    {
        public LinkedListNode head { get; set; }
        public LinkedListNode tail { get; set; }
        public void Append(Object value)
        {
            var newNode = new LinkedListNode(value);
            if (head is null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }
        public void Prepend(Object value)
        {
            var newNode = new LinkedListNode(value);
            newNode.Next = head;
            head = newNode;
            if (tail is null)
            {
                tail = newNode;
            }
        }
    }
}