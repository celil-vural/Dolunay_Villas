using Entity.RequestParameters;
using Microsoft.AspNetCore.Mvc;

namespace Dolunay_Villas.Components
{
    public class VillaFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(VillaRequestParameters? v = null)
        {
            return View("default", v);
        }
    }
}
