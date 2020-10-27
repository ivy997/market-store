namespace MarketStore
{
	public class Gold : DiscountCard
	{
		private const decimal baseDiscountRate = 2m;

		public Gold(decimal turnover, decimal purchaseValue)
		{
			this.Turnover = turnover;
			this.PurchaseValue = purchaseValue;
		}

		public override decimal DiscountRate { get => this.CalculateDiscountRate(); }

		protected override decimal CalculateDiscountRate()
		{
			decimal discountRateIncrementation = this.Turnover / 100;

			if (discountRateIncrementation + baseDiscountRate <= 10)
			{
				return baseDiscountRate + discountRateIncrementation;
			}
			else
			{
				return 10m;
			}
		}
	}
}
