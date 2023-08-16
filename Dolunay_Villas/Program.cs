using Dolunay_Villas.Infrastructure.Config;
using PostSharp.Patterns.Caching;
using PostSharp.Patterns.Caching.Backends;

var builder = WebApplication.CreateBuilder(args);
CachingServices.DefaultBackend = new MemoryCachingBackend();
builder.ConfigureBuilder();
var app = builder.Build();
app.ConfigureApp();
app.Run();