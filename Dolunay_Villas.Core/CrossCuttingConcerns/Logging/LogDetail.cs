namespace Dolunay_Villas.Core.CrossCuttingConcerns.Logging
{
    public class LogDetail
    {
        public string FullName { get; set; } = string.Empty;
        public string MethodName { get; set; } = string.Empty;
        public string ExceptionMessage { get; set; } = string.Empty;
        public List<LogParameter> LogParameters { get; set; }
    }
}
