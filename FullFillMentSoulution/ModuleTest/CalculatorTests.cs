using Moq;
using Xunit;

public interface IDependency
{
    int GetNumber();
}

public class SystemUnderTest
{
    private readonly IDependency _dependency;

    public SystemUnderTest(IDependency dependency)
    {
        _dependency = dependency;
    }

    public int UseDependency()
    {
        return _dependency.GetNumber();
    }
}

public class MyTests
{
    [Fact]
    public void TestMethod()
    {
        // Arrange
        var mock = new Mock<IDependency>();
        mock.Setup(p => p.GetNumber()).Returns(42);

        var sut = new SystemUnderTest(mock.Object);

        // Act
        int result = sut.UseDependency();

        // Assert
        Assert.Equal(42, result);
    }
}
