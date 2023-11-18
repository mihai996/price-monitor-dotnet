using System;

namespace PriceMonitor.Domain.Entities;

public class Offer
{
	public Price Price { get; private set; }

	public Price DiscountedPrice { get; private set; }

	public DateTime DateTime { get; private set; }

    public Offer(Price price, Price discountedPrice, DateTime dateTime)
	{
		Price = price;
		DiscountedPrice = discountedPrice;
		DateTime = dateTime;
	}
}

