using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.DefaultComponents
{
    public class _DefaultOfferComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
