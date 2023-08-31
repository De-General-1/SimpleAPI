namespace SimpleAPI.Test;
using SimpleAPI.Controllers;

public class UnitTest1
{
    ValuesController controller = new ValuesController();

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("De-General", returnValue.Value);
    }
    [Fact]
    public void Test1()
    {

    }
}