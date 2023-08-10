namespace Dolunay_Villas.Infrastructure.Extensions
{
    public static class LoggingExtensions
    {
        public static void LogSetting(this ILoggingBuilder builder)
        {
            builder.ClearProviders();
        }
    }
}
