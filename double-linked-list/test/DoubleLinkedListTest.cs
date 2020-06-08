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
        [Fact]
        public void AppendNullItemToDoubleLinkedListTest()
        {
            //Given
            var variableX = new DoubleLinkedList();
            Object variable1 = null;
            //When
            //Then
            Assert.Throws<ArgumentNullException>(() =>
            variableX.Append(variable1)
            );
        }
        [Fact]
        public void AppendOneItemToEmptyDoubleLinkedListTest()
        {
            //Given
            var variableX = new DoubleLinkedList();
            var variable1 = 1;
            //When
            variableX.Append(variable1);
            //Then
            Assert.Equal(variable1, variableX.Head.Value);
            Assert.Equal(variable1, variableX.Tail.Value);
            Assert.Null(variableX.Head.Next);
            Assert.Null(variableX.Head.Previous);
            Assert.Null(variableX.Tail.Next);
            Assert.Null(variableX.Tail.Previous);
        }
        [Fact]
        public void AppendMultipleItemToEmptyDoubleLinkedListTest()
        {
            //Given
            var variableX = new DoubleLinkedList();
            var variable1 = 1;
            var variable2 = 2;
            var variable3 = 3;
            var variable4 = 4;
            //When
            variableX.Append(variable1);
            variableX.Append(variable2);
            variableX.Append(variable3);
            variableX.Append(variable4);
            //Then
            Assert.Equal(variable1, variableX.Head.Value);
            Assert.Equal(variable2, variableX.Head.Next.Value);
            Assert.Equal(variable3, variableX.Head.Next.Next.Value);
            Assert.Equal(variable4, variableX.Head.Next.Next.Next.Value);
            Assert.Equal(variable4, variableX.Tail.Value);
            Assert.Equal(variable3, variableX.Tail.Previous.Value);
            Assert.Equal(variable2, variableX.Tail.Previous.Previous.Value);
            Assert.Equal(variable1, variableX.Tail.Previous.Previous.Previous.Value);
        }
    }
}
