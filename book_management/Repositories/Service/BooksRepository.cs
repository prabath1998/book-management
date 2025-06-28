using book_management.Models;
using book_management.Repositories.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management.Repositories.Service
{
    class BooksRepository : IBooksRepository
    {
        private readonly string connectionString = "Server=localhost;Database=books_db;Uid=root;Pwd=12345678";

        public void AddBook(Book book)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO books(name, author) VALUES (@name, @author)";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", book.Name);
                        command.Parameters.AddWithValue("@author", book.Author);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Asas");

            }
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM books ORDER BY id DESC";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book();
                                book.Id = reader.GetInt32("id");
                                book.Name = reader.GetString("name");
                                book.Author = reader.GetString("author");


                                books.Add(book);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return books;
        }
    }
}
