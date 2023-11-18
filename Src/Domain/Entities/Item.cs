using System;

namespace PriceMonitor.Domain.Entities;

public class Item
{
	public Guid Guid { get; private set; }

    public string Locator { get; private set; }

    public string Name { get; private set; }

	public Item(string locator, string name)
	{
		Guid = Guid.NewGuid();
		Locator = locator;
		Name = name;
	}

    public Item(Guid guid, string locator, string name)
    {
        Guid = guid;
        Locator = locator;
        Name = name;
    }
}
