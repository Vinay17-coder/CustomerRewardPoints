using Newtonsoft.Json;
using RewardPoints.Models;
using System.Collections.Generic;

namespace RewardPoints.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly string _filePath;
        List<Transaction> transactions = new List<Transaction>
        {
            new Transaction { CustomerId = 1, Amount = 120, TransactionDate = new DateTime(2023, 8, 1, 10, 0, 0) },
            new Transaction { CustomerId = 1, Amount = 130, TransactionDate = new DateTime(2023, 8, 10, 11, 30, 0) },
            new Transaction { CustomerId = 1, Amount = 140, TransactionDate = new DateTime(2023, 8, 15, 14, 0, 0) },
            new Transaction { CustomerId = 1, Amount = 100, TransactionDate = new DateTime(2023, 9, 2, 16, 0, 0) },
            new Transaction { CustomerId = 1, Amount = 90, TransactionDate = new DateTime(2023, 9, 7, 17, 30, 0) },
            new Transaction { CustomerId = 1, Amount = 120, TransactionDate = new DateTime(2023, 9, 15, 12, 30, 0) },
            new Transaction { CustomerId = 1, Amount = 150, TransactionDate = new DateTime(2023, 9, 20, 9, 0, 0) },
            new Transaction { CustomerId = 1, Amount = 180, TransactionDate = new DateTime(2023, 10, 5, 13, 0, 0) },
            new Transaction { CustomerId = 1, Amount = 110, TransactionDate = new DateTime(2023, 10, 11, 11, 45, 0) },
            new Transaction { CustomerId = 1, Amount = 160, TransactionDate = new DateTime(2023, 10, 20, 14, 30, 0) },
            new Transaction { CustomerId = 1, Amount = 140, TransactionDate = new DateTime(2023, 11, 1, 10, 0, 0) },
            new Transaction { CustomerId = 1, Amount = 120, TransactionDate = new DateTime(2023, 11, 12, 13, 15, 0) },
            new Transaction { CustomerId = 1, Amount = 130, TransactionDate = new DateTime(2023, 11, 20, 9, 30, 0) },
            new Transaction { CustomerId = 1, Amount = 150, TransactionDate = new DateTime(2023, 12, 1, 16, 0, 0) },
            new Transaction { CustomerId = 1, Amount = 180, TransactionDate = new DateTime(2023, 12, 5, 10, 0, 0) },
            new Transaction { CustomerId = 2, Amount = 80, TransactionDate = new DateTime(2023, 8, 3, 9, 30, 0) },
            new Transaction { CustomerId = 2, Amount = 90, TransactionDate = new DateTime(2023, 8, 12, 14, 0, 0) },
            new Transaction { CustomerId = 2, Amount = 100, TransactionDate = new DateTime(2023, 8, 18, 11, 30, 0) },
            new Transaction { CustomerId = 2, Amount = 70, TransactionDate = new DateTime(2023, 9, 5, 13, 0, 0) },
            new Transaction { CustomerId = 2, Amount = 80, TransactionDate = new DateTime(2023, 9, 9, 15, 45, 0) },
            new Transaction { CustomerId = 2, Amount = 90, TransactionDate = new DateTime(2023, 9, 14, 12, 0, 0) },
            new Transaction { CustomerId = 2, Amount = 110, TransactionDate = new DateTime(2023, 9, 20, 16, 0, 0) },
            new Transaction { CustomerId = 2, Amount = 130, TransactionDate = new DateTime(2023, 10, 5, 13, 30, 0) },
            new Transaction { CustomerId = 2, Amount = 100, TransactionDate = new DateTime(2023, 10, 12, 11, 0, 0) },
            new Transaction { CustomerId = 2, Amount = 120, TransactionDate = new DateTime(2023, 10, 15, 10, 15, 0) },
            new Transaction { CustomerId = 2, Amount = 140, TransactionDate = new DateTime(2023, 11, 2, 14, 0, 0) },
            new Transaction { CustomerId = 2, Amount = 110, TransactionDate = new DateTime(2023, 11, 10, 17, 30, 0) },
            new Transaction { CustomerId = 2, Amount = 150, TransactionDate = new DateTime(2023, 11, 18, 16, 0, 0) },
            new Transaction { CustomerId = 2, Amount = 160, TransactionDate = new DateTime(2023, 12, 2, 12, 45, 0) },
            new Transaction { CustomerId = 2, Amount = 130, TransactionDate = new DateTime(2023, 12, 10, 15, 30, 0) },
            new Transaction { CustomerId = 3, Amount = 220, TransactionDate = new DateTime(2023, 8, 2, 11, 0, 0) },
            new Transaction { CustomerId = 3, Amount = 240, TransactionDate = new DateTime(2023, 8, 15, 12, 30, 0) },
            new Transaction { CustomerId = 3, Amount = 250, TransactionDate = new DateTime(2023, 8, 20, 10, 45, 0) },
            new Transaction { CustomerId = 3, Amount = 300, TransactionDate = new DateTime(2023, 9, 5, 13, 15, 0) },
            new Transaction { CustomerId = 3, Amount = 350, TransactionDate = new DateTime(2023, 9, 15, 16, 30, 0) },
            new Transaction { CustomerId = 3, Amount = 200, TransactionDate = new DateTime(2023, 9, 25, 11, 0, 0) },
            new Transaction { CustomerId = 3, Amount = 280, TransactionDate = new DateTime(2023, 10, 5, 14, 0, 0) },
            new Transaction { CustomerId = 3, Amount = 250, TransactionDate = new DateTime(2023, 10, 12, 16, 30, 0) },
            new Transaction { CustomerId = 3, Amount = 230, TransactionDate = new DateTime(2023, 10, 18, 15, 0, 0) },
            new Transaction { CustomerId = 3, Amount = 210, TransactionDate = new DateTime(2023, 11, 1, 14, 30, 0) },
            new Transaction { CustomerId = 3, Amount = 240, TransactionDate = new DateTime(2023, 11, 6, 12, 30, 0) },
            new Transaction { CustomerId = 3, Amount = 230, TransactionDate = new DateTime(2023, 11, 15, 16, 45, 0) },
            new Transaction { CustomerId = 3, Amount = 300, TransactionDate = new DateTime(2023, 12, 1, 13, 0, 0) },
            new Transaction { CustomerId = 3, Amount = 320, TransactionDate = new DateTime(2023, 12, 10, 15, 30, 0) },
            new Transaction { CustomerId = 4, Amount = 150, TransactionDate = new DateTime(2023, 8, 1, 10, 30, 0) },
            new Transaction { CustomerId = 4, Amount = 170, TransactionDate = new DateTime(2023, 8, 5, 9, 0, 0) },
            new Transaction { CustomerId = 4, Amount = 160, TransactionDate = new DateTime(2023, 8, 12, 14, 30, 0) },
            new Transaction { CustomerId = 4, Amount = 180, TransactionDate = new DateTime(2023, 9, 4, 10, 0, 0) },
            new Transaction { CustomerId = 4, Amount = 210, TransactionDate = new DateTime(2023, 9, 8, 15, 30, 0) },
            new Transaction { CustomerId = 4, Amount = 220, TransactionDate = new DateTime(2023, 9, 12, 11, 15, 0) },
            new Transaction { CustomerId = 4, Amount = 230, TransactionDate = new DateTime(2023, 9, 20, 13, 30, 0) },
            new Transaction { CustomerId = 4, Amount = 240, TransactionDate = new DateTime(2023, 10, 2, 14, 0, 0) },
            new Transaction { CustomerId = 4, Amount = 250, TransactionDate = new DateTime(2023, 10, 7, 16, 45, 0) },
            new Transaction { CustomerId = 4, Amount = 260, TransactionDate = new DateTime(2023, 10, 15, 14, 30, 0) },
            new Transaction { CustomerId = 4, Amount = 270, TransactionDate = new DateTime(2023, 12, 2, 15, 0, 0) },
            new Transaction { CustomerId = 4, Amount = 280, TransactionDate = new DateTime(2023, 12, 10, 16, 30, 0) }
        };
        public TransactionRepository()
        {
            _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "transactions.json");

        }

        public async Task<List<Transaction>> GetAllTransactionsAsync()
        {

            //todo -- here we can use actual DB calls to get the transactions 
            // return this.transactions;  this is for when we want to use static list of transactions instead of reading the json file
            if (!File.Exists(_filePath))
                throw new FileNotFoundException($"file not found at {_filePath}");

            var jsonTransactionData = await File.ReadAllTextAsync(_filePath);

            if (string.IsNullOrWhiteSpace(jsonTransactionData))
            {
                throw new Exception("The JSON file is empty - No transactins found ");
            }

            List<Transaction> transactions = JsonConvert.DeserializeObject<List<Transaction>>(jsonTransactionData);


            return transactions ?? new List<Transaction>();
        }
    }
}
