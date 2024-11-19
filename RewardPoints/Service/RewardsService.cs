using RewardPoints.@interface;
using RewardPoints.Models;
using System.Collections.Concurrent;

namespace RewardPoints.Service
{
    public class RewardsService : IRewardsService
    {
        private readonly ITransactionRepository _transactionRepository;

        public RewardsService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        public int CalculateRewardPoints(decimal amount)
        {
            int points = 0;

            if (amount > 100)
            {
                points += (int)((amount - 100) * 2); //Points for dollars over $100 multiply with 2
                points += 50; // Points for the first $50 over $50
            }
            else if (amount > 50)
            {
                points += (int)(amount - 50);
            }

            return points;
        }
        public async Task<List<CustomerRewards>> CalculateRewardsAsync()
        {
            var transactions = await _transactionRepository.GetAllTransactionsAsync(); // get all customer transactions

            ConcurrentDictionary<int, CustomerRewards> rewardsByCustomer = new ConcurrentDictionary<int, CustomerRewards>();

            // Group the transactions by CustomerId as this is CPU bound operation we need to use tasks in order to improve speed
            var groupedTransactions = transactions.GroupBy(x => x.CustomerId); 

            var tasks = groupedTransactions.Select(async group =>
            {
                var customerId = group.Key; // here key means customerId
                var customerRewards = new CustomerRewards
                {
                    CustomerId = customerId,
                    CustomerName = $"Customer {customerId}"
                };

                foreach (var transaction in group)
                {
                    var monthKey = transaction.TransactionDate.ToString("yyyy-MM");
                    var points = CalculateRewardPoints(transaction.Amount);// Calculate  points for the customer

                    if (!customerRewards.MonthlyPoints.ContainsKey(monthKey))
                    {
                        customerRewards.MonthlyPoints[monthKey] = 0;
                    }
                    customerRewards.MonthlyPoints[monthKey] += points;
                    customerRewards.TotalPoints += points;

                }

                rewardsByCustomer[customerId] = customerRewards;
            }).ToList();

            // Running all customer tasks in parallel  and wait for all to finish the calucations
            await Task.WhenAll(tasks);

            // Return the list of customer rewards
            return rewardsByCustomer.Values.ToList();
        }
    }
}
