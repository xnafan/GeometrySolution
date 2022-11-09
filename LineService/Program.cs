using LineDataAccess.Providers;

namespace LineService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<ILineProvider, InMemoryLineProvider>();
            //builder.Services.AddSingleton<ILineProvider>(_ => new MsSqlLineProvider("Server=.;Database=Geometry;Trusted_Connection=True;"));

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
                app.UseSwagger();
                app.UseSwaggerUI();
            

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}