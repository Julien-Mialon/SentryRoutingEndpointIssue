internal class Program
{
    public static void Main(string[] args)
    {
        //*
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
                webBuilder.UseSentry((context, options) =>
                {
                    options.Dsn = "https://xxxxxxxxxxx@sentry.io/11111";
                    options.Release = "1.0.0";
                });
                
            })
            .Build()
            .Run();
    }
}