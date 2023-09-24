using Microsoft.OpenApi.Models;

namespace Telecare_Backend.Extension_Method
{
    public static class SwaggerExtension
    {
        //Swagger Configuration
        public static void SwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo() { Title = "Telecare API", Version = "v1" });
            });
        }

        //Swagger UI configuration

        public static void ConfigureSwaggerUI(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //handle error for production code
            }

            app.Use(async (contex, next) =>
            {
                if(contex.Request.Path == "/")
                {
                    contex.Response.Redirect("/swagger/index.html");
                }
                else
                {
                    await next();
                }
            });

            app.UseSwagger();
            app.UseSwaggerUI(swoption =>
            {
                swoption.SwaggerEndpoint("/swagger/v1/swagger.json", "Telecare API v1");
            });
        }
    }
}
