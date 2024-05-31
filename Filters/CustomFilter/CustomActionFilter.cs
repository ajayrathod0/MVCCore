using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.CustomFilter
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {

            string Action = context.RouteData.Values["action"].ToString();
            string Controller = context.RouteData.Values["Controller"].ToString();

            Console.WriteLine($"Controller : {Controller} Action Method : {Action}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"CustomResourceFilter OnResourceExecuting Called : {DateTime.Now}");
        }
    }
}
