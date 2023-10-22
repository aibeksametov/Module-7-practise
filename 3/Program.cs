public class Money
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Money operator +(Money money1, Money money2)
    {
        if (money1.Currency == money2.Currency)
        {
            return new Money(money1.Amount + money2.Amount, money1.Currency);
        }
        // Реализация конвертации по курсу
        // Здесь вы должны определить курс и выполнить конвертацию
        return money1;
    }

    public static bool operator ==(Money money1, Money money2)
    {
        return money1.Amount == money2.Amount && money1.Currency == money2.Currency;
    }

    public static bool operator !=(Money money1, Money money2)
    {
        return money1.Amount != money2.Amount || money1.Currency != money2.Currency;
    }
}
