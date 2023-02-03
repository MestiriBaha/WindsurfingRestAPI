using Microsoft.EntityFrameworkCore;
using WindsurfingRestAPI.DBcontext;
using WindsurfingRestAPI.Services;

namespace WindsurfingRestAPI.ProjectStartup
{
    internal static class StartupHelperExtension
    {
        // we will be adding services to the container , we are splitting services from the program.cs file in order to avoid many lines of codes in a configuration file ! 

        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers(configuration => configuration.ReturnHttpNotAcceptable = true).AddXmlDataContractSerializerFormatters(); 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IWindsurfingRepository, WindsurfingRepository>();
            builder.Services.AddDbContext<Windsurfdatabase>(options =>
            {
                //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

            });
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return builder.Build(); 
        }
        //configuring the Request/Response Pipeline
        public static WebApplication ConfigurePipeline (this WebApplication webApplication)
        {
            if (webApplication.Environment.IsDevelopment())
            {
                webApplication.UseDeveloperExceptionPage(); 
            }
            else
            {
                webApplication.UseExceptionHandler(optionbuilder =>
                {
                    optionbuilder.Run(async context => { context.Response.StatusCode = 500;
                        await context.Response.WriteAsync("an unexpected error has occured , try again later ! ");
                    }); 
                });
            }
            webApplication.UseAuthorization();
            webApplication.MapControllers(); 
            return webApplication;  
        }

    }
}
