using System;
using System.Collections.Generic;

namespace LinkedListLibrary
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> head { get; set; }
        public LinkedListNode<T> tail { get; set; }
        public void Append(T value)
        {
            var newNode = new LinkedListNode<T>(value);
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
        public void Prepend(T value)
        {
            var newNode = new LinkedListNode<T>(value);
            newNode.Next = head;
            head = newNode;
            if (tail is null)
            {
                tail = newNode;
            }
        }
        public bool Contains(T value)
        {
            var n = head;

            while (n != null && !EqualityComparer<T>.Default.Equals(n.Value, value) )
            {
                n = n.Next;
            }
            if (n is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}