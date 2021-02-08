using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OGSSurvey.Service.Data;
using System;

namespace OGSSurvey.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractFinderConroller:ControllerBase
    {
        private readonly ILogger<ContractFinderConroller> _logger;
        private readonly IRepository _repository;
        private readonly IContractMapper _contractMapper;

        public ContractFinderConroller(ILogger<ContractFinderConroller> logger, IRepository repository, IContractMapper contractMapper)
        {
            _logger = logger;
            _repository = repository;
            _contractMapper = contractMapper;
        }
        [HttpGet("contractId")]
        public IActionResult FindContractById(int contractId)
        {
            try
            {
                var contract = _repository.GetContractById(contractId);
                var model = _contractMapper.MapContract(contract);
                if (model != null)
                {
                    _logger.LogInformation("FindContractById Method Called for {Contract Id} {Result}", contractId, "Success");
                    return Ok(model);
                }
                else
                {
                    _logger.LogInformation("FindContractById Method Called for {Contract Id} {Result}", contractId, "Not Found");
                    return NotFound();
                }                
            }
            catch (Exception ex)
            {
                _logger.LogInformation("FindContractById Method Called for {Contract Id} {Result}", contractId, ex.Message);
            }
            _logger.LogInformation("FindContractById Method Called for {Contract Id} {Result}", contractId, "Bad Request");
            return BadRequest("Failed to get the contract!");
        }
        [HttpGet("guid")]
        public IActionResult FindContractByGuid(Guid guid)
        {
            try
            {
                var contract = _repository.GetContractByGuid(guid);
                var model = _contractMapper.MapContract(contract);
                if (model != null)
                {
                    _logger.LogInformation("FindContractByGuid Method Called for {Contract guid} {Result}", guid, "Success");
                    return Ok(model);
                }
                else
                {
                    _logger.LogInformation("FindContractByGuid Method Called for {Contract guid} {Result}", guid, "Not Found");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("FindContractByGuid Method Called for {Contract guid} {Result}", guid, ex.Message);
            }
            _logger.LogInformation("FindContractByGuid Method Called for {Contract guid} {Result}", guid, "Bad Request");
            return BadRequest("Failed to get the contract!");
        }
        [HttpGet("tcno")]
        public IActionResult FindContractByTcNo(string tcno)
        {
            try
            {
                var contract = _repository.GetContractByTcNo(tcno);
                var model = _contractMapper.MapContract(contract);
                if (model != null)
                {
                    _logger.LogInformation("FindContractByTcNo Method Called for {Contract tcno} {Result}", tcno, "Success");
                    return Ok(model);
                }
                else
                {
                    _logger.LogInformation("FindContractByTcNo Method Called for {Contract tcno} {Result}", tcno, "Not Found");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("FindContractByTcNo Method Called for {Contract tcno} {Result}", tcno, ex.Message);
            }
            _logger.LogInformation("FindContractByTcNo Method Called for {Contract tcno} {Result}", tcno, "Bad Request");
            return BadRequest("Failed to get the contract!");
        }
    }
}
