using Microsoft.AspNetCore.Mvc;

namespace HughesApartments.Controllers
{
    public class UtilitiesController : Controller
    {
        public ContentResult Electricity() 
        {
            return new ContentResult()
            {
                Content = "Entergy"
            };
        }

    }
}
