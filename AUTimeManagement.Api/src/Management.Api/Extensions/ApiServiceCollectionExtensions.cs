using AUTimeManagement.Api.Business.Logic;

namespace AUTimeManagement.Api.Management.Api.Extensions;

public static class ApiServiceCollectionExtensions
{
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        //TODO add honeycomb

        builder.Services.ConfigureServices();
        return builder;
    }

    private static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        services.AddCustomSecurity();

        services.AddBusinessLogic();



        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    private static void AddCustomSecurity(this IServiceCollection services)
    {

    }
}

