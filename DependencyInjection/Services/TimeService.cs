namespace DependencyInjection.Services
{
    public class TimeService : ITimeService
    {
        public string Time => DateTime.Now.ToString("hh:mm:ss");
    }
}
