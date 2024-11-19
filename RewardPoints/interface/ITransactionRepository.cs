
using RewardPoints.Models;

public interface ITransactionRepository
{
    Task<List<Transaction>> GetAllTransactionsAsync();
}

