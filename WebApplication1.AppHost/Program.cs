using Google.Protobuf.WellKnownTypes;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebApplication1>("webapplication1");

Console.WriteLine(builder.Environment.EnvironmentName);
builder.Build().Run();
