namespace DailyActivityTracker.BLL.Services
{
    public class Facade
    {
        public static AuthService AuthServices => new AuthService();
    }
}
