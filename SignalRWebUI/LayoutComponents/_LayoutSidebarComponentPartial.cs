using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.LayoutComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
