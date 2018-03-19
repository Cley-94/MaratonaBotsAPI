using System.Web.Http;
using System.Web.Http.Results;
using WebAPIInstruments.Models;
using WebAPIInstruments.Service;
using System.Collections.Generic;
using WebAPIInstruments.Interface;

namespace WebAPIInstruments.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IServiceInstrument _serviceInstrument;
        public HomeController()
        {
            _serviceInstrument = new ServiceInstrument();
        }
        
        [HttpGet]
        public JsonResult<List<InstrumentsModel>> GetAllInstruments()
        {
            var instruments = _serviceInstrument.GetAllInstruments();

            return Json(instruments);
        }
    }
}