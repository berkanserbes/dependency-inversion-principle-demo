namespace dependency_inversion_principle_demo;

public class Payment
{
	public double Amount { get; set; }
	public Payment(double amount)
	{
		Amount = amount;
	}
}
