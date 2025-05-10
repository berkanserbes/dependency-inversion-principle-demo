namespace dependency_inversion_principle_demo;

public interface IPaymentService
{
	public void ProcessPayment(Payment payment);
}
