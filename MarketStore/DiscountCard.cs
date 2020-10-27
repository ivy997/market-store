namespace MarketStore
{
	using System.Text;

	public abstract class DiscountCard
	{
		public string Owner { get; set; }

		public decimal PurchaseValue { get; set; }

		public decimal Turnover { get; set; }

		public abstract decimal DiscountRate { get; }

		protected decimal Discount { get => this.CalculateDiscount(); }

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"Purchase value: ${this.PurchaseValue:f2}")
			  .AppendLine($"Discount rate: {this.DiscountRate:f1}%")
			  .AppendLine($"Discount: ${this.Discount:f2}")
			  .AppendLine($"Total: ${(this.PurchaseValue - this.Discount):f2}");

			return sb.ToString().TrimEnd();
		}

		protected abstract decimal CalculateDiscountRate();

		private decimal CalculateDiscount()
		{
			return this.PurchaseValue * this.DiscountRate / 100;
		}
	}
}
