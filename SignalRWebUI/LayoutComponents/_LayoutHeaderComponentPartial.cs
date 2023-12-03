using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.LayoutComponents
{
    public class _LayoutHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
