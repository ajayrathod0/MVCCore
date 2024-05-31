using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.CustomFilter
{
    public class CustomExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string message = context.Exception.Message;
            string stackTrace = context.Exception.StackTrace;

            string Controller = context.RouteData.Values["controller"].ToString();
            string Action = context.RouteData.Values["action"].ToString();

            context.ExceptionHandled = true;

            context.Result = new ViewResult() { ViewName = "Error" };
        }
    }
}
