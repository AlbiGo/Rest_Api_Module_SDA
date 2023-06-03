﻿using DataLayer.Models;
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
        [HttpGet("merrlibrat")]
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

        [HttpGet("merrliberid")]
        public IActionResult MerrLiberID(int ID)
        {
            if (ID == 0)
            {
                throw new Exception("ID nuk eshte e sakte");
            }
            //Hapi 1
            //Merr librat ne memorie
            var librat = GjeneroLibra();
            var liber = librat.Where(p => p.ID.Equals(ID))
                .FirstOrDefault();

            //Kthe not found nqs nuk ka liber me kete ID
            if(liber == null)
            {
                return NotFound();
            }

            return Ok(liber);
        }

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
