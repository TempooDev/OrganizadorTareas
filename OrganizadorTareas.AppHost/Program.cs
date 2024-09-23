var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.OrganizadorTareas_ApiService>("apiservice");

builder.AddProject<Projects.OrganizadorTareas_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
