class Card
{
    public string Number;
    public Account Account;
    public int Limit;
    public int LastPayment;
    public bool IsBlocked;

    public Card(string number, Account account, int limit)
    {
        Number = number;
        Account = account;
        Limit = limit;
        LastPayment = 0;
        IsBlocked = false;
    }

    public void Show()
    {
        string state = IsBlocked ? "заблокирована" : "активна";
        Console.WriteLine($"Карта {Number}: лимит платежа {Limit} тг, {state}");
    }
}
