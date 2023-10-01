using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiView.Models;
namespace ApiView.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private DbModel _db;

        public ApiController(DbModel db)
        {
            _db = db;
        }
        [Route("GetApiData")]
        public IActionResult GetApiData()
        {   
            var data = _db.apies.ToList();
            return Ok(data);            
        }
        [Route("DeleteApiData/{id}")]
        public IActionResult Delete(int id)
        {
            var data = _db.apies.FirstOrDefault(x => x.Id == id);           
            _db.apies.Remove(data);   
            return Ok("Delete Success");
        }

    }
}
