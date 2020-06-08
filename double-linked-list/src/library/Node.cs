using System;

namespace library
{
    public class Node
    {
        public Object Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public Node(Object value)
        {
            this.Value = value;
        }
    }
}