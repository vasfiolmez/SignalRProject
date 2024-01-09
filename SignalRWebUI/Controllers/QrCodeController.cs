using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace SignalRWebUI.Controllers
{
    public class QrCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index() 
        { 
        return View();
        }
        [HttpPost]
        public IActionResult Index(string value)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator createQrCode = new QRCodeGenerator();
                QRCodeGenerator.QRCode squareCode = createQrCode.CreateQrCode(value,QRCodeGenerator.ECCLevel.Q);
                using (Bitmap ımage = squareCode.GetGraphic(10)) 
                {
                    ımage.Save(ms, ImageFormat.Png);
                    ViewBag.QrCodeImage = "data:image/png;base64,"
                        +Convert.ToBase64String(ms.ToArray());
                }
            }
            return View();
        }
    }
}
