using ProjectB3_API.Application.Services;
using ProjectB3_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectB3_API.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class InvestmentController : ApiController
    {
        private readonly InvestmentService _investmentService;

        public InvestmentController()
        {
            _investmentService = new InvestmentService();
        }

        [HttpPost]
        [Route("api/investment/calculate")]
        public IHttpActionResult CalculateInvestment([FromBody] Investment investment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _investmentService.CalculateInvestment(investment.InitialValue, investment.Months);
            return Ok(result);
        }
    }
}
