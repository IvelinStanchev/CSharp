using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Sider";
        string secondName = "Videnov";
        string thirdName = "Volenov";
        double balanceAmount = 11.5;
        string bankName = "UniCredit Bulbank";
        string iBan = "IT 96 W 05849 12049 129416264859";
        string bicCode = "BYALED1JAGA";
        long firstCreditcardNumber = 1201481648127128;
        long secondCreditcardNumber = 7750177295631250;
        long thirdCreditcardNumber = 1648812624197599;
        Console.WriteLine("An employee's information is: ");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Middle name: {0}", secondName);
            Console.WriteLine("Last name: {0}", thirdName);
            Console.WriteLine("Balance of credit card: {0} billions", balanceAmount);
            Console.WriteLine("The name of the bank: {0}",bankName);
            Console.WriteLine("IBAN: {0}", iBan);
            Console.WriteLine("BIC code: {0}", bicCode);
            Console.WriteLine("First credit card number: {0}", firstCreditcardNumber);
            Console.WriteLine("Second credit card number: {0}", secondCreditcardNumber);
            Console.WriteLine("Third credit card number: {0}", thirdCreditcardNumber);
    }
}

