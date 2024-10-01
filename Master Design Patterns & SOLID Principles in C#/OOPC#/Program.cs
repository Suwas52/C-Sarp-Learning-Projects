// Encapsulation
// Encaption is hiding the internal data and provide only the necessary part to outside world


using OOPC_.src.OopPrinciples.Encapsulation;

BadBankAccount badAccount = new BadBankAccount();

badAccount.balance = -59;

if (badAccount.balance < 0)
{
    System.Console.WriteLine("Balance is less then 0");
}

System.Console.WriteLine(badAccount.balance);
