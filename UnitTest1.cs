namespace UnitTestPractice;

public class UnitTest1
{
    // [Fact]
    // public void PassingTest()
    // {
    //     Assert.Equal(4, Add(2,2));
    //
    // }
    //
    // [Fact]
    // public void FailingTest()
    // {
    //     Assert.Equal(5, Add(2,2));
    // }
    //
    // int Add(int x, int y)
    // {
    //     return x + y;
    // }
    //
    // [Theory]
    // [InlineData(3)]
    // [InlineData(5)]
    // [InlineData(6)]
    // public void MyFirstTheory(int value)
    // {
    //     Assert.True(IsOdd(value));
    // }
    //
    // bool IsOdd(int value)
    // {
    //     return value % 2 == 1;
    // }


    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("world", "dlrow")]
    [InlineData("", "")]
    [InlineData(null, null)]
    public void TestReverseString(string input, string expected)
    {
        var methodsForTesting = new MethodsForTesting();
        Assert.Equal(expected, methodsForTesting.ReverseString(input));
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(-2, true)]
    [InlineData(20, true)]
    [InlineData(37, false)]
    public void TestIsEven(int number, bool expected)
    {
        var methodsForTesting = new MethodsForTesting();
        Assert.Equal(expected, methodsForTesting.IsEven(number));
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 6)]
    [InlineData(new int[] { 54, 34, 7, 3, 457, 356, 234 }, 457)]
    [InlineData(new int[] { -1, -324, -545, 0, 11, 234, 244, -2, -43 }, 244)]
    public void TestFindMax(int[] numbers, int expected)
    {
        var methodsForTesting = new MethodsForTesting();
        Assert.Equal(expected, methodsForTesting.FindMax(numbers));
    }

    [Fact]
    public void TestFindMax_ThrowsArgumentException_OnNullArray()
    {
        var methodsForTesting = new MethodsForTesting();
        Assert.Throws<ArgumentException>(() => methodsForTesting.FindMax(null));
    }

    [Fact]
    public void TestFindMax_ThrowsArgumentException_OnEmptyArray()
    {
        var methodsForTesting = new MethodsForTesting();
        Assert.Throws<ArgumentException>(() => methodsForTesting.FindMax(new int[] { }));
    }

    [Theory]
    [InlineData("food", 'o', 2)]
    [InlineData("greg", 'e', 1)]
    [InlineData("asdf", 'd', 1)]
    [InlineData(null, 'a', 0)]
    public void TestCountOccurences(string input, char character, int expected)
    {
        var methodsForTesting = new MethodsForTesting();
        Assert.Equal(expected, methodsForTesting.CountOccurences(input, character));
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 6 }, new int[] { 1, 2, 3, 4, 6 })]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 6 }, new int[] { 1, 2, 3, 4,5, 6 })]
    [InlineData(new int[] { 1, 1, 2, 2 }, new int[] {1,2})]
    [InlineData(null,null)]
    public void TestRemoveDuplicates(int[] input, int[] expected)
    {
        var methodsForTesting = new MethodsForTesting();
        Assert.Equal(expected, methodsForTesting.RemoveDuplicates(input));
    }
    
}