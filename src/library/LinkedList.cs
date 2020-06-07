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
        public bool Contains(Object value)
        {
            var n = head;
            while (n != null && !Equals(n.Value, value))
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
        public void Delete(Object value)
        {
            if (head is null)
            {
                throw new NullReferenceException();
            }
            // var deletedNode = head;
            var deletedNode = head;
            if (head.Value.Equals(value))
            {
                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next;
                }
                return;
            }
            while (deletedNode != null && !Equals(deletedNode.Value, value))
            {
                deletedNode = deletedNode.Next;
            }
            var tmpNode = head;
            while (tmpNode != null && tmpNode.Next != deletedNode)
            {
                if (deletedNode == tail)
                {
                    tail = tmpNode.Next;
                }
                tmpNode = tmpNode.Next;
            }
            tmpNode.Next = deletedNode.Next;

        }
    }
}