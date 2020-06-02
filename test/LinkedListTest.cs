using LinkedListLibrary;
using Xunit;

namespace linked_list_test
{
    public class LinkedListTest
    {
        [Fact]
        public void EmptyLinkedListTest()
        {
            //Given
            var variableX = new LinkedList();
            //When

            //Then
            Assert.Null(variableX.head);
            Assert.Null(variableX.tail);
        }
        [Fact]
        public void AppendOneObjectToEmptLinkedListTest()
        {
            //Given
            var variableX = new LinkedList();
            var variable1 = 1;
            //When
            variableX.Append(variable1);
            //Then
            Assert.Equal(variable1, variableX.head.Value);
            Assert.Equal(variable1, variableX.tail.Value);
            Assert.Null(variableX.head.Next);
            Assert.Null(variableX.tail.Next);
            Assert.Equal(variableX.head, variableX.tail);
        }
        [Fact]
        public void AppendThreeItensToLinkedListTest()
        {
            //Given
            var variableX = new LinkedList();
            var variable1 = 1;
            var variable2 = 2;
            var variable3 = 3;
            //When
            variableX.Append(variable1);
            variableX.Append(variable2);
            variableX.Append(variable3);
            //Then
            Assert.Equal(variable1, variableX.head.Value);
            Assert.NotNull(variableX.head.Next);
            Assert.Null(variableX.tail.Next);
            Assert.NotEqual(variableX.head, variableX.tail);
            Assert.Equal(variable2, variableX.head.Next.Value);
            Assert.Equal(variable3, variableX.head.Next.Next.Value);
        }
        [Fact]
        public void PrependAddFirstObjectTest()
        {
            //Given
            var variableX = new LinkedList();
            var variable1 = 1;
            //When
            variableX.Prepend(variable1);
            //Then
            Assert.Equal(variable1, variableX.head.Value);
            Assert.Equal(variable1, variableX.tail.Value);
            Assert.Null(variableX.head.Next);
            Assert.Null(variableX.tail.Next);
        }
        [Fact]
        public void ContainsValueTest()
        {
            //Given
            var variableX = new LinkedList();
            var variable1 = 1;
            var variable2 = 2;
            var variable3 = 3;
            //When
            variableX.Append(variable1);
            variableX.Append(variable2);
            variableX.Append(variable3);
            //Then
            Assert.True(variableX.Contains(2));
            Assert.False(variableX.Contains(4));
        }
    }
}