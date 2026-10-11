class Account
{
    public string Number;
    public int Balance;
    public bool IsClosed;

    public Account(string number, int balance)
    {
        Number = number;
        Balance = balance;
        IsClosed = false;
    }

    public bool Withdraw(int sum)
    {
        if (IsClosed)
        {
            Console.WriteLine($"Счёт {Number} аннулирован");
            return false;
        }
        if (sum > Balance)
        {
            Console.WriteLine($"На счёте {Number} недостаточно средств");
            return false;
        }
        Balance = Balance - sum;
        return true;
    }

    public bool Deposit(int sum)
    {
        if (IsClosed)
        {
            Console.WriteLine($"Счёт {Number} аннулирован");
            return false;
        }
        Balance = Balance + sum;
        return true;
    }

    public void Show()
    {
        string state = IsClosed ? "аннулирован" : "активен";
        Console.WriteLine($"Счёт {Number}: {Balance} тг, {state}");
    }
}
