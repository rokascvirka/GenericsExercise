using GenericsExercise.Models;

namespace GenericsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book(1, "Harry Potter", 1),
                new Book(2, "Eragon", 2),
                new Book(3, "Harka", 3),
                new Book(4, "Harry Potter", 4),
                new Book(5, "Harry Potter", 5),
                new Book(6, "Harry Potter", 6),
                new Book(7, "Harry Potter", 7),
                new Book(8, "Harry Potter", 8)
            };
                
              
            List<Customer> customers = new List<Customer>
            {
                new Customer(1, "Rokas", "Pilaitė"),
                new Customer(2, "Ignas", "Pilaitė"),
                new Customer(3, "Viktorija", "Pilaitė"),
                new Customer(4,"Karolis", "Pilaitė"),
                new Customer(5, "Marius", "Pilaitė"),
                new Customer(6, "Tadas", "Pilaitė"),
                new Customer(7, "Andrius", "Pilaitė"),
                new Customer(8, "Mantas", "Pilaitė"),
                new Customer(9, "Greta", "Pilaitė")
            };

            var bookRepo = new GenericRepository<Book>();
            var customerRepo = new GenericRepository<Customer>();

            var cs = new Book("rokas", 17);
            var gks = new Book("eminemas", 12);
            bookRepo.Database = books;
            bookRepo.AddEntity(cs);
            bookRepo.AddEntity(gks);

            foreach (var book in books)
            {
                Console.WriteLine($"Id: {book.Id}, title: {book.Title}, price: {book.Price}");
            }
            var byId = bookRepo.GetById(9);
            Console.WriteLine($"Id: {byId.Id}, title: {byId.Title}, price: {byId.Price}");

            byId.Id = 100;
            byId.Price = 1000;

            bookRepo.Update( byId );
            var byId100 = bookRepo.GetById(100);
            Console.WriteLine($"Id: {byId100.Id}, title: {byId100.Title}, price: {byId100.Price}");

            bookRepo.DeleteEntity(100);

            Console.WriteLine();
            foreach (var book in books)
            {
                Console.WriteLine($"Id: {book.Id}, title: {book.Title}, price: {book.Price}");
            }



        }
    }
}