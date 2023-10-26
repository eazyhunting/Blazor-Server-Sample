using BlazorServerSample.Services.Interfaces;

namespace BlazorServerSample.Services
{
    public class NotifierService : INotifierService
    {
        public async Task Update(int value)
        {
            if (Notify != null)
            {
                await Notify.Invoke(value);
            }
        }

        public event Func<int, Task>? Notify;
    }
}
