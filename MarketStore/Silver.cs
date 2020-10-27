namespace MarketStore
{
	public class Silver : DiscountCard
	{
		private const decimal baseDiscountRate = 2m;

		public Silver(decimal turnover, decimal purchaseValue)
		{
			this.Turnover = turnover;
			this.PurchaseValue = purchaseValue;
		}

		public override decimal DiscountRate { get => this.CalculateDiscountRate(); }

		protected override decimal CalculateDiscountRate()
		{
			if (this.Turnover > 300)
			{
				return 3.5m;
			}

			return baseDiscountRate;
		}
	}
}
