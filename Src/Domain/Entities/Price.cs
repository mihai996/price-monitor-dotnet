using System;

namespace PriceMonitor.Domain.Entities;

public class Price
{
	public int Amount { get; private set; }
	public Currency Currency { get; private set; }

	public Price(int amount, Currency currency)
	{
		Amount = amount;
		Currency = currency;
	}
}
