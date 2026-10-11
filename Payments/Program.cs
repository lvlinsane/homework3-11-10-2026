class Program
{
    static void Main()
    {
        Account account1 = new Account("KZ001", 100000);
        Card card1 = new Card("1111", account1, 30000);
        Client client1 = new Client("Алексей", account1, card1);

        Account account2 = new Account("KZ002", 5000);
        Card card2 = new Card("2222", account2, 30000);
        Client client2 = new Client("Мария", account2, card2);

        Administrator admin = new Administrator("Иванов");

        Order order1 = new Order(1, "Наушники", 1500);
        Order order2 = new Order(2, "Ноутбук", 40000);
        Order order3 = new Order(3, "Книга", 2000);

        client1.PayOrder(order1);
        admin.CheckCard(card1);
        Console.WriteLine();

        client1.Transfer(account2, 2000);
        Console.WriteLine();

        client1.PayOrder(order2);
        admin.CheckCard(card1);
        client1.PayOrder(order3);
        Console.WriteLine();

        client2.BlockCard();
        client2.PayOrder(order3);
        client2.CloseAccount();
        Console.WriteLine();

        client1.Transfer(account2, 1000);
        Console.WriteLine();

        account1.Show();
        account2.Show();
        card1.Show();
        card2.Show();
        order1.Show();
        order2.Show();
        order3.Show();
    }
}
