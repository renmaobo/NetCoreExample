using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Example.Middleware.Middlewares
{
    /// <summary>
    /// token check middleware
    /// </summary>
    public class TokenCheckMiddleware
    {
        public TokenCheckMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public TokenCheckMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            this._next = next;
            this._configuration = configuration;
        }

        /// <summary>
        /// next middleware
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// configuration setting
        /// </summary>
        private readonly IConfiguration _configuration;

        /// <summary>
        /// async invoke
        /// </summary>
        /// <param name="context">httpcontext</param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {
            // there write token check code.
            if (true)// pass check
            {
                await this._next(context);
            }
            else
            {
                context.Response.StatusCode = 501;
                context.Response.WriteAsync("{ status: 501, errmsg: 'token is invalid, please check token calcute format.' }");
            }
        }
    }
}
