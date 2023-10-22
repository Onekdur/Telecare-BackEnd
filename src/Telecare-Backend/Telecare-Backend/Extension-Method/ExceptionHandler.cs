using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using Telecare.Domain.Error;
using Telecare.Domain.Logger;

namespace Telecare_Backend.Extension_Method
{
    public static class ExceptionHandler
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILogggerManager loggerManager)
        {
            app.UseExceptionHandler(err =>
            {
                err.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if(contextFeature != null)
                    {
                        loggerManager.LogError($"Something went wrong {contextFeature.Error}");

                        await context.Response.WriteAsync(new ErrorModel()
                        {
                            Message = "Internal Server Error",
                            StatusCode = context.Response.StatusCode
                        }.ToString());



                        /// মাথা কাজ করছে না আমার 
                        ///কিছু ভাল লাগছে না। 


                    }
                });
            });
        }
    }
}
