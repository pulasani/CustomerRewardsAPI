using CustomerRewards.Domain;
using CustomerRewards.Model.CustomModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerRewardsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _customerRepository;
        private readonly ILogger _logger;
        public CustomerController(ICustomerRepository customerRepository, ILogger<CustomerController> logger)
        {
            _customerRepository = customerRepository;
            _logger = logger;
        }

        [Route("GetCustomersRewardPoints")]
        [HttpGet]
        public async Task<IActionResult> GetCustomersRewardPoints()
        {
            try
            {
                _logger.LogInformation("GetCustomersRewardPoints method start.");
                 var customerTransactions = _customerRepository.GetCustomerRewardPointsByMonths();
                _logger.LogInformation("GetCustomersRewardPoints : Count of Customer Transactions -" +customerTransactions.Count());
                _logger.LogInformation("GetCustomersRewardPoints method end.");
                return Ok(await Task.FromResult(customerTransactions));
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception in GetCustomersRewardPoints : " + ex.Message);
                return BadRequest("Could not fetch customer transactions data");
            }
            
        }
    }
}
