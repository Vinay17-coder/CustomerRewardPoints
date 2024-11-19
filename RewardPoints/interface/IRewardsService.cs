using RewardPoints.Models;

namespace RewardPoints.@interface
{
    public interface IRewardsService
    {
        Task<List<CustomerRewards>> CalculateRewardsAsync();
    }
}
