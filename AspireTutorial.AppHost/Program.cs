var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireTutorial_ApiService>("apiservice");

builder.AddProject<Projects.AspireTutorial_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
