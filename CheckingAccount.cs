public class CheckingAccount : BankAccount {
  public CheckingAccount(string newCustomerName, double newBalance) : base(newCustomerName, newBalance) {
    depoist(100); // ALL checking accounts created get $100 more in their balance
  }
};