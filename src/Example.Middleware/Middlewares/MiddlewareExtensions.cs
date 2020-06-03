using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Example.Middleware.Middlewares;

namespace Example.Middleware
{
    /// <summary>
    /// middleware extensions
    /// </summary>
    public static class MiddlewareExtensions
    {
        /// <summary>
        /// enable use token chekck
        /// </summary>
        /// <param name="app"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseTokenCheck(this IApplicationBuilder app, IConfiguration configuration)
        {
            return app.UseMiddleware<TokenCheckMiddleware>(configuration);
        }

        /// <summary>
        /// enable use token check
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseTokenCheck(this IApplicationBuilder app)
        {
            return app.UseMiddleware<TokenCheckMiddleware>();
        }
    }
}
