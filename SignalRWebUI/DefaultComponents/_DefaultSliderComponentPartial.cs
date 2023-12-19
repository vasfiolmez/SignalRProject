using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.DefaultComponents
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
