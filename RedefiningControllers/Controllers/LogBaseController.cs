using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RedefiningControllers.Controllers
{
    public abstract class LogBaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Controller: {context.Controller.GetType().Name}");
            Console.WriteLine($"Action: {context.ActionDescriptor.DisplayName}");
            base.OnActionExecuting(context);
        }
    }
}
