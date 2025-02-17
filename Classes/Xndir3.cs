namespace ConsoleApp3;

class BankAccount {
    public string acount;
    public string holder;
    public int balance;
    public BankAccount(string acount, string holder, int balance) {
        this.acount = acount;
        this.holder = holder;
        this.balance = balance;
    }

    public void Withdrawl(int money) {
        if (money < 0) {
            Console.WriteLine("Enter Positive amount");
            return;
        }
        if (balance <= 0 || money > balance) {
            Console.WriteLine("You dont have enough money to Withdraw");
            return;
        }
        balance -= money;
        Console.WriteLine("After Withdrawl " + balance);
    }

    public void Deposit(int money) {
        balance += money;
        Console.WriteLine("After Deposit: " + balance);
    }

    public void Display() {
        Console.WriteLine($"{acount} {holder}: {balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount("1854687585", "Aram", 100);
        while (true) {
            Console.WriteLine("Enter option you want\n1.Withdraw\n2.Depsot\n3.Display Account\n4.exit");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            switch (operation) {
                case '1':
                    Console.WriteLine("Enter money to withdraw");
                    int money_with = Convert.ToInt32(Console.ReadLine());
                    bankAccount.Withdrawl(money_with);
                    break;
                case '2':
                    Console.WriteLine("Enter money to Deposit");
                    int money_dep = Convert.ToInt32(Console.ReadLine());
                    bankAccount.Deposit(money_dep);
                    break;
                case '3':
                    bankAccount.Display();
                    break;
                case '4':
                   Console.WriteLine("Thanks for visiting our bank!");
                   return;
                default:
                    Console.WriteLine("Enter other operation");
                    break;
            }
        }
    }
}
