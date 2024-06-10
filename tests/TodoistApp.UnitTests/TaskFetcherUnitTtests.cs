
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

        [Fact]
        public void GetNumberOfTasks_Should_Return_1()
        {
            var numberOfTasks = new TaskFetcher().GetNumberOfTasks();
            Assert.Equal(1, numberOfTasks);
        }
        // [Fact]
        // public void IsPrime_InputIs1_ReturnFalse()
        // {
        //     var primeService = new PrimeService();
        //     bool result = primeService.IsPrime(1);
        //     Assert.False(result, "1 should not be prime");

        // }
        
    }
}
