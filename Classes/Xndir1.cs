namespace ConsoleApp1;

class PhoneBook {
    public string name;
    public string phone_number;
    public string email;

    public PhoneBook(string name, string phone_number, string email) {
        this.name = name;
        this.phone_number = phone_number;
        this.email = email;
    }

    public void DisplayInfo() {
        Console.WriteLine($"{name}: {phone_number} {email}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhoneBook[] phonebooks= new PhoneBook[3];
        for (int i = 0; i < phonebooks.Length; ++i) {
            Console.WriteLine("Enter name, phone, email");
            string name = new string(Console.ReadLine());
            string phone = new string (Console.ReadLine());
            string email = new string (Console.ReadLine());
            phonebooks[i] = new PhoneBook(name, phone, email);
        }

        Console.WriteLine("Enter name to find");
        string target = new string(Console.ReadLine());

        foreach (PhoneBook phonebook in phonebooks) {
            if (phonebook.name.Equals(target)) {
                phonebook.DisplayInfo();
                break;
            }
        }
    }
}
