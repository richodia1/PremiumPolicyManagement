
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PolicyManagementApi.Models;
using PolicyManagementApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyPremiumController : ControllerBase
    {
        private readonly IPolicyPremiumService policyPremiumService;

        public PolicyPremiumController(IPolicyPremiumService policyPremiumService)
        {
            this.policyPremiumService = policyPremiumService;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllPolicy()
        {
            try
            {
                return Ok(await policyPremiumService.GetAllPolicy());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPost]
        public async Task<ActionResult<Policy>> CreateEmployee(Policy policy)
        {
            try
            {
                if (policy == null)
                    return BadRequest();

                var createdPolicy = await policyPremiumService.AddPolicy(policy);

                return CreatedAtAction(nameof(Policy),
                    new { id = createdPolicy.Id }, createdPolicy);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new Policy record");
            }
        }

        //[HttpGet("request-lookup")]
        //public async Task<IActionResult> Lookup()
        //{

        //}
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Policy>> GetPolicy(int id)
        {
            try
            {
                var result = await policyPremiumService.GetPolicy(id);

                if (result == null) return NotFound();

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("request-lookup")]
        public IActionResult Lookup()
        {
            return Ok(policyPremiumService.GetLookUpData());
        }
        [HttpPut]
        public async Task<ActionResult<Policy>> UpdatePolicy(Policy policy)
        {
            try
            {
                if ( policy.Id !=0)
                    return BadRequest("Policy ID mismatch");

                var policyToUpdate = await policyPremiumService.GetPolicy(policy.Id);

                if (policyToUpdate == null)
                    return NotFound($"Policy premium was not found");

                return await policyPremiumService.Updatepolicy(policy);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating Policy");
            }
        }
    }
}
