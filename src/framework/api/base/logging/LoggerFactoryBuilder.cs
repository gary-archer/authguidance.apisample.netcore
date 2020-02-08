namespace Framework.Api.Base.Logging
{
    /*
     * A simple builder class to expose a segregated interface
     */
    public class LoggerFactoryBuilder
    {
        public static ILoggerFactory Create()
        {
            return new LoggerFactory();
        }
    }
}