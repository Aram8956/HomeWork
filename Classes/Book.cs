using System.Runtime.CompilerServices;

namespace ConsoleApp4;

class Book {
    public string title;
    public string author;
    public bool isAvalaible;

    public Book(string title, string author, bool isAvalaible) {
        this.title = title;
        this.author = author;
        this.isAvalaible = isAvalaible;
    }

    public void BorrowBook() {
        isAvalaible = false;
    }

    public void ReturnBook() {
        isAvalaible = true; 
    }

    public void Dispaly() {
        Console.WriteLine($"{title} of {author}: {isAvalaible}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[3];
        for (int i = 0; i < 3; ++i) {
            Console.WriteLine("Enter Book title");
            string title = new string(Console.ReadLine());
            Console.WriteLine("Enter Authors name");
            string author = new string (Console.ReadLine());
            books[i] = new Book(title, author, true);
        }

        books[0].BorrowBook();

        for (int i = 0; i < 3; ++i) {
            books[0].Dispaly();
        }
    }
}
