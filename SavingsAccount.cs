public class SavingsAccount : BankAccount
{
  public SavingsAccount(string newCustomerName, double newBalance)
  : base(newCustomerName, newBalance)
  { // next line for visual sake
    depoist(200);
  }
}