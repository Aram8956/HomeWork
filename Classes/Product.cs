namespace ConsoleApp5;

class Product {
    public string name;
    public decimal price;
    public int quantity;

    public Product(string name, decimal price, int quantity) {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }
    public decimal TotalPrice()
    {
        return price * quantity;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[7];
        int count = 0;
        decimal final = 0;

        while (count < 7) {
            Console.WriteLine("Enter product name and its price");
            Console.WriteLine("If you want to stop write exit");
            string name = new string(Console.ReadLine());
            if (name == "exit") {
                Console.WriteLine("Thank you for coming");
                break;
            }
            Console.WriteLine("Enter its price and quantity");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            int quantity = Convert.ToInt32(Console.ReadLine());
            products[count] = new Product(name, price, quantity);
            ++count;
            final += products[count].TotalPrice();
        }
        
        if (count >= 5) {
            final = final - (0.1m * final);
        }

        Console.WriteLine($"Your final price is: {final}");
    }
}
