using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.DefaultComponents
{
    public class _DefaultOurMenuComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {  return View(); }
    }
}
