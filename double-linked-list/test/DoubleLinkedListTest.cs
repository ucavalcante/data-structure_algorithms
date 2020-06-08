using System;
using Xunit;
using double_linked_list;

namespace double_linked_list_test
{
    public class DoubleLinkedListTest
    {
        [Fact]
        public void EmptyDoubleLinkedListTest()
        {
            //Given
            var variableX = new DoubleLinkedList();
            //When
            //Then
            Assert.Null(variableX.Head);
            Assert.Null(variableX.Tail);
        }
    }
}
