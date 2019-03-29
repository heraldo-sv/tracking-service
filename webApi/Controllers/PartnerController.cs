using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        // GET: api/Partner
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Partner/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Partner
        [HttpPost]
        public void Post([FromBody] PartnerDto partnerDto)
        {
            ActionResult result = null;
            if (!ModelState.IsValid) BadRequest(partnerDto);
            //var response = _partnerGateway.add(partnerDto);

            //result = response.Success
            //        ? Ok(response.Message)
            //        : StatusCode(500, response.Message);

            //return result;
        }

        // PUT: api/Partner/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
