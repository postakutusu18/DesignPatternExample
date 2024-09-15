namespace StrategyPattern;

public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    // Stratejiyi ayarlar
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    // Stratejiye göre ödemeyi gerçekleştirir
    public void MakePayment(decimal amount)
    {
        _paymentStrategy.Pay(amount);
    }
}
