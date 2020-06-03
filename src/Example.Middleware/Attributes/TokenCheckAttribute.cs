using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Example.Middleware.Attributes
{
    /// <summary>
    /// token check attribute
    /// </summary>
    public class TokenCheckAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// token code
        /// </summary>
        private const string TOKEN = "token";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // there write token check code.
            base.OnActionExecuting(context);
        }
    }
}
