class Administrator
{
    public string Name;

    public Administrator(string name)
    {
        Name = name;
    }

    public void CheckCard(Card card)
    {
        if (card.LastPayment > card.Limit)
        {
            card.IsBlocked = true;
            Console.WriteLine($"Администратор {Name} заблокировал карту {card.Number}: платёж {card.LastPayment} тг превышает лимит {card.Limit} тг");
        }
        else
        {
            Console.WriteLine($"Администратор {Name} проверил карту {card.Number}: нарушений нет");
        }
    }
}
