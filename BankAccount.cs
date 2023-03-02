public class BankAccount {
  
  public string customerName = "";
  public double balance = 0;



// default constructor 
public BankAccount() {
  customerName = "Bob";
  balance = 300;
}

public BankAccount(string newCustomerName, double newBalance) {
  customerName = newCustomerName;
  balance = newBalance;
// if(typeOfAccount == "checking") {
//   balance += 100;
// }

}
public void depoist(double amount) {
  if(amount <= 0) {
    throw new Exception("No negative deposists allowed");
  }
  balance += amount;
}

public double getBalance() {
  return balance;
}
};

