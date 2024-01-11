using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Bibiliotheque.Core.Net.Filters
{
    public class DisabledFilter : Attribute, IResourceFilter
    {
        // Executes after the method is called
        public void OnResourceExecuted(ResourceExecutedContext context)
        {

        }

        // Executes before the method is called
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            // If the route contains a certain path, notify the user that it is no longer available
            if (context.HttpContext.Request.Path.Value.Contains("maroute"))
            {
                context.Result = new BadRequestObjectResult(
                    new
                    {
                        result = new[] { "This method is no longer available" }
                    });
            }
        }
    }
}
