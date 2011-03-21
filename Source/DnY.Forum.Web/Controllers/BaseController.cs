using System.Web.Mvc;

namespace DnY.Forum.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.Title = GetPageTitle();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            View("Error", new ErrorMessageViewModel(filterContext.Exception.Message)).ExecuteResult(ControllerContext);
        }

        public virtual void SetMessage(string msgId)
        {
            TempData["Message"] = MessageSource.GetMessage(msgId);
        }

        protected abstract string GetPageTitle();
    }
}