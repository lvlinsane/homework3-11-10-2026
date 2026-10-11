class Order
{
    public int Id;
    public string Description;
    public int Amount;
    public bool IsPaid;

    public Order(int id, string description, int amount)
    {
        Id = id;
        Description = description;
        Amount = amount;
        IsPaid = false;
    }

    public void Show()
    {
        string state = IsPaid ? "оплачен" : "не оплачен";
        Console.WriteLine($"Заказ {Id} ({Description}): {Amount} тг, {state}");
    }
}
