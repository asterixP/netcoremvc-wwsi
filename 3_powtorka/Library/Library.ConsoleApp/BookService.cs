using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.ConsoleApp
{
    public class BooksService
    {
        BooksRepository _repository;

        public BooksService(BooksRepository booksRepository)
        {
            _repository = booksRepository;
        }

        public void AddBook()
        {
            Console.WriteLine("Podaj tytuł nowej książki:");
            var tytul = Console.ReadLine();
            Console.WriteLine("Podaj autora ksiązki: ");
            var autor = Console.ReadLine();
            Console.WriteLine("Podaj rok publikacji:");
            var rok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj numer ISBN: ");
            var isbn = Console.ReadLine();
            Console.WriteLine("Podaj ilość egzemplazy : ");
            var ilosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj cenę ksiązki: ");
            var cena = Convert.ToDecimal(Console.ReadLine());

            var newBook = new Book(tytul, autor, rok, isbn, ilosc, cena);
            _repository.Insert(newBook);

        }

        public void RemoveBook()
        {
            Console.WriteLine("Podaj tytuł książki do usunięcia: ");
            var tytul = Console.ReadLine();
            _repository.RemobeByTitle(tytul);
        }

        public void ListBooks()
        {
            Console.WriteLine("lista ksiazek:");
            var books = _repository.GetAll();
            foreach (var item in books)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void ChangeState()
        {
            Console.WriteLine("Podaj tytuł książki której stan chcesz zmienić: ");
            var tytul = Console.ReadLine();
            Console.WriteLine("Podaj aktualny stan ksiązki:");
            var stan = Convert.ToInt32(Console.ReadLine());

            _repository.ChangeState(tytul, stan);
        }
    }
}