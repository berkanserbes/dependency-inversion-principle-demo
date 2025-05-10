namespace dependency_inversion_principle_demo;

public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the amount to be paid: ");
		string input = Console.ReadLine();

		if (!double.TryParse(input, out double inputAmount) || inputAmount <= 0)
		{
			Console.WriteLine("Invalid input. Please enter a positive numeric value.");
			return;
		}

		Payment payment = new Payment(amount: inputAmount);

		IPaymentService paypalService = new Paypal();
		IPaymentService stripeService = new Stripe();
		IPaymentService applePayService = new ApplePay();

		PaymentProcessor stripeProcessor = new PaymentProcessor(stripeService);
		stripeProcessor.ProcessPayment(payment);

		PaymentProcessor paypalProcessor = new PaymentProcessor(paypalService);
		paypalProcessor.ProcessPayment(payment);

		PaymentProcessor applePayProcessor = new PaymentProcessor(applePayService);
		applePayProcessor.ProcessPayment(payment);
	}
}
