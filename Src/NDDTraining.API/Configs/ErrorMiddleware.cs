using System.Net;
using NDDTraining.Domain.DTOS;

namespace NDDTraining.API.Configs
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await ExceptionTreatment(httpContext, ex);
            }
        }
        private Task ExceptionTreatment(HttpContext context, Exception exception)
        {
            HttpStatusCode status;
            string message;

            switch (exception)
            {
                default:
                    status = HttpStatusCode.InternalServerError;
                    message = "An internal error ocurred. Please contact IT";
                    break;
            }

            ErrorDTO response = new(message);
            context.Response.StatusCode = (int)status;
            return context.Response.WriteAsJsonAsync(response);
        }
    }

}
