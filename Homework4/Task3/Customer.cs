namespace Task3;

public class Customer
{
    public string FullName { get; private set; }
    public long CardNumber { get; private set; }
    private int Pin;
    private double Balance;

    public Customer(string fullName, long cardNumber, int pin, double balance)
    {
        FullName = fullName;
        CardNumber = cardNumber;
        Pin = pin;
        Balance = balance;
    }

    public bool Authenticate(int enteredPin)
    {
        return enteredPin == Pin;
    }

    public double GetBalance()
    {
        return Balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }

}