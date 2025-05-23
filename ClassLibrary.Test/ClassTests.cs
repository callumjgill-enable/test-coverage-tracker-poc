namespace ClassLibrary.Test;

public sealed class ClassTests
{
    [Fact]
    public void MethodToTest_ReturnsTrue()
    {
        // Arrange
        bool returnTrue = true;

        // Act
        bool result = Class.MethodToTest(returnTrue);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void MethodToTest_ReturnsFalse()
    {
        // Arrange
        bool returnTrue = false;

        // Act
        bool result = Class.MethodToTest(returnTrue);

        // Assert
        Assert.False(result);
    }
}
