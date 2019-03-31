using System;

public class BankAccount
{
    private bool isOpen = false;
    private decimal balance = 0;
    private object _lock = new object();

    public void Open()
    {
        lock (_lock)
        {
            isOpen = true;
        }
    }

    public void Close()
    {
        lock (_lock)
        {
            isOpen = false;
        }
    }

    public decimal Balance
    {
        get
        {
            lock (_lock)
            {
                if (isOpen)
                    return balance;
                else
                    throw new InvalidOperationException();
        }
    }
        set
        {
            lock (_lock)
            {
                balance = value;
            }
        }
    }

    public void UpdateBalance(decimal change)
    {
        lock (_lock)
        {
            Balance += change;
        }
}
}
