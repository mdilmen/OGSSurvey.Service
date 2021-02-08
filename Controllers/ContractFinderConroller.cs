using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OGSSurvey.Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGSSurvey.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractFinderConroller:ControllerBase
    {
        private readonly ILogger<ContractFinderConroller> _logger;
        private readonly IRepository _repository;

        public ContractFinderConroller(ILogger<ContractFinderConroller> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        [HttpGet("contractId")]
        public IActionResult FindContractById(int contractId)
        {
            //try
            //{

            //    var policeLog = _repository.GetLog(id);
            //    if (policeLog != null)
            //    {
            //        _logger.LogInformation("GetRequestLog Method Called for {Police Hareket Id} {Result}", id, "Success");
            //        return Ok(policeLog.RequestXml);
            //    }
            //    else
            //    {
            //        _logger.LogInformation("GetRequestLog Method Called for {Police Hareket Id} {Result}", id, "Not Found");
            //        return NotFound();
            //    }
            //    //return Ok("123123");
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogInformation("GetRequestLog Method Called for {Police Hareket Id} {Result}", id, ex.Message);
            //}
            //_logger.LogInformation("GetRequestLog Method Called for {Police Hareket Id} {Result}", id, "Bad Request");
            //return BadRequest("Failed to get the log item");

            var contract = _repository.GetContractById(contractId);

        }
    }
}
