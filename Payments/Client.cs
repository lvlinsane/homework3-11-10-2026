class Client
{
    public string Name;
    public Account Account;
    public Card Card;

    public Client(string name, Account account, Card card)
    {
        Name = name;
        Account = account;
        Card = card;
    }

    public void PayOrder(Order order)
    {
        Console.WriteLine($"Клиент {Name} оплачивает заказ {order.Id} на {order.Amount} тг");

        if (order.IsPaid)
        {
            Console.WriteLine("Заказ уже оплачен");
            return;
        }
        if (Card.IsBlocked)
        {
            Console.WriteLine("Карта заблокирована, оплата невозможна");
            return;
        }

        bool ok = Account.Withdraw(order.Amount);
        if (ok)
        {
            order.IsPaid = true;
            Card.LastPayment = order.Amount;
            Console.WriteLine("Заказ оплачен");
        }
    }

    public void Transfer(Account toAccount, int sum)
    {
        Console.WriteLine($"Клиент {Name} переводит {sum} тг на счёт {toAccount.Number}");

        if (toAccount.IsClosed)
        {
            Console.WriteLine($"Счёт {toAccount.Number} аннулирован, перевод невозможен");
            return;
        }

        bool ok = Account.Withdraw(sum);
        if (ok)
        {
            toAccount.Deposit(sum);
            Console.WriteLine("Перевод выполнен");
        }
    }

    public void BlockCard()
    {
        Card.IsBlocked = true;
        Console.WriteLine($"Клиент {Name} заблокировал карту {Card.Number}");
    }

    public void CloseAccount()
    {
        Console.WriteLine($"Клиент {Name} аннулирует счёт {Account.Number}, остаток {Account.Balance} тг выдан");
        Account.Balance = 0;
        Account.IsClosed = true;
        Card.IsBlocked = true;
    }
}
