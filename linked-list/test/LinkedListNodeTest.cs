using System;
using LinkedListLibrary;
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
            var nodeItem = new LinkedListNode<int>(variable1);
            //Then
            Assert.Equal(1, nodeItem.Value);
            Assert.Null(nodeItem.Next);
        }
      }
}
