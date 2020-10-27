namespace MarketStore
{
	public class Bronze : DiscountCard
	{
		private const decimal discountRate = 0m;

		public Bronze(decimal turnover, decimal purchaseValue)
		{
			this.Turnover = turnover;
			this.PurchaseValue = purchaseValue;
		}

		public override decimal DiscountRate { get => this.CalculateDiscountRate(); }

		protected override decimal CalculateDiscountRate()
		{
			if (this.Turnover >= 100 && this.Turnover <= 300)
			{
				return 1m;
			}
			else if(this.Turnover > 300)
			{
				return 2.5m;
			}

			return discountRate;
		}
	}
}
