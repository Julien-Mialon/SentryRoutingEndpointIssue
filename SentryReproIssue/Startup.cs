public class Startup
{
    public Startup(IConfiguration configuration, IHostEnvironment environment)
    {
        
    }

    public virtual void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddControllers();
    }

    public virtual void Configure(IApplicationBuilder app, IHostEnvironment env)
    {
        // this does not work
        //*
        app.UseRouting()
            .UseEndpoints(endpoints => endpoints.MapControllers());
        // */
        
        // this work
        /*
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
        // */
    }
}