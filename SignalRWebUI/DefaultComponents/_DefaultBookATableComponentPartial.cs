using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.DefaultComponents
{
    public class _DefaultBookATableComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
