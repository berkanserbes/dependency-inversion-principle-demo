namespace dependency_inversion_principle_demo;

public class ApplePay : IPaymentService
{
	public void ProcessPayment(Payment payment)
	{
		Console.WriteLine($"Processing payment of {payment.Amount} using Apple Pay.");
	}
}
