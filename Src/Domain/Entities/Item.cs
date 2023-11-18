using System;

namespace PriceMonitor.Domain.Entities;

public class Item
{
	public Guid Guid { get; private set; }

    public string Locator { get; private set; }

    public string Name { get; private set; }

    public Item(Guid? guid, string locator, string name)
    {
        Guid = guid ?? Guid.NewGuid();
        Locator = locator;
        Name = name;
    }
}
