namespace RewardPoints.Models
{
    public class CustomerRewards
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Dictionary<string, int> MonthlyPoints { get; set; } = new Dictionary<string, int>();
        public int TotalPoints { get; set; }
    }
}
