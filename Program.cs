var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<TestService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .RegisterService<TestService>(ServiceKind.Resolver)
    .AddDataLoader<TestDataLoader>()
    .ModifyRequestOptions(o => o.IncludeExceptionDetails = true);

var app = builder.Build();

app.MapGraphQL();

await app.RunAsync();
