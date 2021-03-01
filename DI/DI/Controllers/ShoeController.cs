using Services;
using System.Web.Mvc;

namespace DI.Controllers
{
    public class ShoeController : Controller
    {
        private IShoeService _iShoeService;

        public ShoeController(IShoeService iShoeService)
        {
            _iShoeService = iShoeService;
        }
        
        public ActionResult GetShoes()
        {
            return Json(_iShoeService.GetShoes(), JsonRequestBehavior.AllowGet);
        }
    }
}