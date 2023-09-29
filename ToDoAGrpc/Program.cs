using Microsoft.EntityFrameworkCore;
using ToDoAGrpc.Services;
using ToDoGrpc.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite("Data Source=ToDoDatabase"));
builder.Services.AddGrpc();



var app = builder.Build();


app.MapGrpcService<GreeterService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
