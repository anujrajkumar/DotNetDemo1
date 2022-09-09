
using TodoistApp.Blazor.Services;

namespace TodoistApp.UnitTests
{
    public class TaskFetcherUnitTtests
    {
        [Fact]
        public void GetNumberOfTasks_Should_Return_0()
        {
            var numberOfTasks = new TaskFetcher().GetNumberOfTasks();
            Assert.Equal(0, numberOfTasks);
        }
    }
}