namespace dependency_inversion_principle_demo;

public class PaymentProcessor
{
	private readonly IPaymentService _paymentService;
	public PaymentProcessor(IPaymentService paymentService)
	{
		_paymentService = paymentService;
	}
	public void ProcessPayment(Payment payment)
	{
		_paymentService.ProcessPayment(payment);
	}
}
