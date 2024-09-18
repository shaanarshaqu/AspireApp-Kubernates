var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireApp3_ApiService>("apiservice");

builder.AddProject<Projects.AspireApp3_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
