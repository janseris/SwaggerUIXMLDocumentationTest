using System.Reflection;

namespace SwaggerUITest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            
            //include methods documentation
            builder.Services.AddSwaggerGen(options =>
            {
                //xml documentation generating must be enabled in Project -> Properties -> Build
                //when <response> tags are used in functions documentation in controllers,
                //use case description is displayed on each status code
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"; //project name.xml (default)
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}