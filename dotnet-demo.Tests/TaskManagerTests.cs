using Xunit;

public class TaskManagerTests
{
    [Fact]
    public void GetPendingTaskCount_ShouldReturn2()
    {
        var manager = new TaskManager();

        Assert.Equal(2, manager.GetPendingTaskCount());
    }

    [Fact]
    public void GetCompletedTaskCount_ShouldReturn1()
    {
        var manager = new TaskManager();

        Assert.Equal(1, manager.GetCompletedTaskCount());
    }

    [Fact]
    public void GetNextTask_ShouldReturnReviewPullRequest()
    {
        var manager = new TaskManager();

        Assert.Equal("Review pull request", manager.GetNextTask());
    }
}