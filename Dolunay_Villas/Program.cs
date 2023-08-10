using Dolunay_Villas.Infrastructure.Config;
var builder = WebApplication.CreateBuilder(args);
builder.ConfigureBuilder();
var app = builder.Build();
app.ConfigureApp();
app.Run();