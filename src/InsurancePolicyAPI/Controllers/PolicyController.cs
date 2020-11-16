using InsurancePolicyAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InsurancePolicyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PolicyController : ControllerBase
    {
      
        private readonly ILogger<PolicyController> _logger;

        public PolicyController(ILogger<PolicyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Policy> Get(string id)
        {
            if (id != "123" && id != "456")
                return NotFound();

            
            return Policy.PopulateDummyPolicy(id);
        }
    }
}
