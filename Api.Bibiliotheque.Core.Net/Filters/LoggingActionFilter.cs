using Api.Bibiliotheque.Core.Net.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Bibiliotheque.Core.Net.Filters
{
    public class LoggingActionFilter : IActionFilter
    {
        private readonly ILogger<LoggingActionFilter> _logger;

        public LoggingActionFilter(ILogger<LoggingActionFilter> logger)
        {
            _logger = logger;
        }

        // After the action, execute this part
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogWarning($"End of API call log: {context.ActionDescriptor.DisplayName} at {DateTime.Now}");
        }

        // Before the action, execute this part
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogWarning($"API call log: {context.ActionDescriptor.DisplayName} at {DateTime.Now}");
        }
    }
}
