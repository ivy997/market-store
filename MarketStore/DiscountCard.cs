namespace MarketStore
{
	using System;
	using System.Text;

	public abstract class DiscountCard
	{
		private decimal purchaseValue;
		private decimal turnover;

		public string Owner { get; set; }

		public decimal PurchaseValue 
		{
			get
			{
				return this.purchaseValue;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Purchase value cannot be negative or zero.");
				}

				purchaseValue = value;
			}
		}

		public decimal Turnover 
		{
			get
			{
				return turnover;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Turnover cannot be negative.");
				}

				turnover = value;
			}
		}

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
