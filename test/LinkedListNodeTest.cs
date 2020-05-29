using System;
using LinkedList;
using Xunit;

namespace linked_list_test
{
    public class LinkedListNodeTest
    {
        [Fact]
        public void CreateLinkedListNodeFirstItem()
        {
            //Given
            var variable1 = 1;
            //When
            var nodeItem = new LinkedListNode(variable1);
            //Then
            Assert.Equal(1, nodeItem.Value);
            Assert.Null(nodeItem.Next);
        }
        [Fact]
        public void CreateLinkedListNodeWithNextItem()
        {
            //Given
            var variable2 = 2;
            var variable1 = 1;
            //When
            var nodeItem2 = new LinkedListNode(variable2);
            var nodeItem1 = new LinkedListNode(variable1, nodeItem2);
            //Then
            Assert.Equal(2, nodeItem2.Value);
            Assert.Null(nodeItem2.Next);
            Assert.Equal(1, nodeItem1.Value);
            Assert.Equal(2, nodeItem1.Next.Value);
            Assert.NotNull(nodeItem1.Next);
        }
    }
}
