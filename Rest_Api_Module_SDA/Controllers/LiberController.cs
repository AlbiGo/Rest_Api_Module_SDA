using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rest_Api_Module_SDA.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LiberController : ControllerBase
    {
        /// <summary>
        /// Merr gjithe librat
        /// </summary>
        /// <returns></returns>
        [HttpGet("MerrLibrat")]
        public IActionResult MerrLibrat()
        {
            //Nqs useri mund ta aksesoje kete api
            //if(false)
            //{
            //    return StatusCode(401);
            //}

            var librat = GjeneroLibra();
            return new OkObjectResult(librat);
        }

        //public IActionResult MerrLiberID(int ID)
        //{

        //}

        private List<Liber> GjeneroLibra()
        {
            var librat = new List<Liber>()
            {
                new Liber()
                {
                    Autori = "Fan Noli",
                    DataKrijimit = DateTime.Now,
                    ID = 1,
                    KategoriID = 1,
                    Status = "Aktiv",
                    Titull = "Skenderbeu"
                },
                new Liber()
                {
                    Autori = "Gustav FLober",
                    DataKrijimit = DateTime.Now,
                    ID = 2,
                    KategoriID = 1,
                    Status = "Aktiv",
                    Titull = "Ema Bovari"
                }
            };
            return librat;
        }
    }
}
