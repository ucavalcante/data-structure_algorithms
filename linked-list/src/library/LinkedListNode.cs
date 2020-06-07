using System;

namespace LinkedListLibrary
{
    public class LinkedListNode
    {
        public Object Value { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode(Object value)
        {
            this.Value = value;
        }
    }
}
