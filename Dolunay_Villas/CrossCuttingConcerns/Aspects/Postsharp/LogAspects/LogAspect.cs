using Dolunay_Villas.CrossCuttingConcerns.Logging;
using Entity.Models;
using Newtonsoft.Json;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using Repository.Contracts;
using System.Reflection;

namespace Dolunay_Villas.Aspects.Postsharp.LogAspects
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method, TargetMemberAttributes = MulticastAttributes.Instance)] //sınıflara konulduğunda constructer ların muaf tutulması için
    public class LogAspect : OnMethodBoundaryAspect
    {
        public ILoggerRepository? logger { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public override void RuntimeInitialize(MethodBase method)
        {
            base.RuntimeInitialize(method);
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            try
            {

                var logParameters = args.Method.GetParameters().Select((t, i) => new LogParameter
                {
                    Name = t.Name,
                    Type = t.ParameterType.Name,
                    Value = args.Arguments.GetArgument(i)
                }).ToList();
                var logDetail = new LogDetail
                {
                    FullName = args.Method.DeclaringType == null ? null : args.Method.DeclaringType.FullName,
                    MethodName = args.Method.Name,
                    LogParameters = logParameters
                };
                var log = new Log()
                {
                    Detail = JsonConvert.SerializeObject(logDetail).ToString(),
                    Audit = "Info",
                    CreatedAt = DateTime.Now,
                    CreatedByUser = _userName,
                    CreatedByUserEmail = _userEmail,
                    UpdatedAt = DateTime.Now,
                };
                _logger.Add(log);
            }
            catch (Exception e) { }
            base.OnEntry(args);
        }
        public override void OnException(MethodExecutionArgs args)
        {
            try
            {

                var logParameters = args.Method.GetParameters().Select((t, i) => new LogParameter
                {
                    Name = t.Name,
                    Type = t.ParameterType.Name,
                    Value = args.Arguments.GetArgument(i)
                }).ToList();
                var logDetail = new LogDetail
                {
                    FullName = args.Method.DeclaringType == null ? null : args.Method.DeclaringType.FullName,
                    MethodName = args.Method.Name,
                    LogParameters = logParameters,
                    ExceptionMessage = args.Exception.Message,
                };
                var log = new Log()
                {
                    Detail = JsonConvert.SerializeObject(logDetail).ToString(),
                    Audit = "Error",
                    CreatedAt = DateTime.Now,
                    CreatedByUser = _userName,
                    CreatedByUserEmail = _userEmail,
                    UpdatedAt = DateTime.Now,
                };
                _logger.Add(log);
            }
            catch (Exception e) { }
            base.OnEntry(args);
        }
    }
}
