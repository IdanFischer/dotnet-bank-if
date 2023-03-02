
BankAccount newaccount = new CheckingAccount("jimbo", 250);
// newaccount.customerName = "jim";



Console.WriteLine(newaccount.customerName + "'s starting balance is $" + newaccount.getBalance());
// he added 100 more
newaccount.depoist(-100);

Console.WriteLine(newaccount.customerName + "'s starting balance is $" + newaccount.getBalance());
