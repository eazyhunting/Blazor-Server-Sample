namespace BlazorServerSample.Services.Interfaces
{
    public interface INotifierService
    {
        event Func<int, Task>? Notify;

        Task Update(int value);
    }
}