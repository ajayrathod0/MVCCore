using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.CustomFilter
{
    
    public class CustomResourceFilter : Attribute, IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"CustomResourceFilter OnResourceExecuting Called : {DateTime.Now}");
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"CustomResourceFilter OnResourceExecuted Called : {DateTime.Now}");

        }
    }
}
