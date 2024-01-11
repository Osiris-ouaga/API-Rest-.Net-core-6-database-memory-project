using Api.Bibiliotheque.Core.Net.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Reflection;

namespace Api.Bibiliotheque.Core.Net.Configuration
{
    /// <summary>
    /// tous nos extensions de service de configuration pour plus de clarté
    /// </summary>
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddSwaggerGenService(this IServiceCollection service)
        {
            service.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "My Library API",
                    Description = "Library management API for my clients.",
                    TermsOfService = new Uri("https://mylibraryapi/terms"),
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Prince Divin MACKPAYEN",
                        Email = "divinmackpayen@gmail.com",
                        Url = new Uri("mailto:divinmackpayen@gmail.com")
                    },
                    License = new Microsoft.OpenApi.Models.OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://mylibraryapi/licenses")
                    }
                });

                // Read the XML file for Swagger
                var xmlHelp = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlHelp));
            });

            return service;
        }

        public static IServiceCollection AddAuthenticationService(this IServiceCollection service)
        {
            service.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = "https://dev-muthwn1c43uk5vrf.eu.auth0.com";
                options.Audience = "https://demonstrationnet6";

            });

            return service;
        }

        public static IServiceCollection AddControllersService(this IServiceCollection service)
        {
            service.AddControllers(options =>
            {
                var policies = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                options.Filters.Add(new AuthorizeFilter(policies));
                options.Filters.Add(new FormattingResultFilter());
                options.Filters.Add<GlobalExceptionFilter>();
                options.Filters.Add<LoggingActionFilter>();
            });

            return service;
        }
    }
}
