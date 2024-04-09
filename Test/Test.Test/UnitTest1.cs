using Test.Console;

namespace Test.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var arr = new[]{1, 5, 9, 10, 5 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(12, result);
    }
    
    [Fact]
    public void Test2()
    {
        var arr = new[]{1, 2, 3};
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Test3()
    {
        var arr = new[]{0, 1, 1, 1, 1, 1, 1, 1, 1, 2 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Test4()
    {
        var arr = new[]{0, 1, 2 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Test5()
    {
        var arr = new[]{1, 1, 1 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Test6()
    {
        var arr = new[]{1, 4, 1, 2 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void Test7()
    {
        var arr = new[]{1, 3, 2, 2 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Test8()
    {
        var arr = new[]{1, 3, 3, 1 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void Test9()
    {
        var arr = new[]{1, 3, 4, 1, 1 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void Test10()
    {
        var arr = new[]{0, 3, 3, 3, 1 };
        var result = Solution.GetMinSteps(arr);
        Assert.Equal(4, result);
    }
}