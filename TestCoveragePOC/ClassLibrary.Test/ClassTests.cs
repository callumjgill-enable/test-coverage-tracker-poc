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
}
