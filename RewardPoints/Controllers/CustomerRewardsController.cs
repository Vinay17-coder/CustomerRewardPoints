using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RewardPoints.@interface;
using RewardPoints.Models;

namespace RewardPoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerRewardsController : ControllerBase
    {
        private readonly IRewardsService _rewardsService;

        public CustomerRewardsController(IRewardsService rewardsService)
        {
            _rewardsService = rewardsService;
        }

        [HttpGet("get-all-customer-reward-points")]
        public async Task<ActionResult<List<CustomerRewards>>> GetCustomerRewardPointssAsync()
        {
            var rewards = await _rewardsService.CalculateRewardsAsync();
            return Ok(rewards);
        }
    }
}
