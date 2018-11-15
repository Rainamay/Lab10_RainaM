namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Models.BookStoreDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore.Models.BookStoreDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Authors.AddOrUpdate(x => x.Id,
        new Author() { Id = 1, Name = "Jane Austen" },
        new Author() { Id = 2, Name = "Charles Dickens" },
        new Author() { Id = 3, Name = "Miguel de Cervantes" },
         new Author() { Id = 4, Name = "J K Rowling" },
          new Author() { Id = 5, Name = "John Grisham" },
           new Author() { Id = 6, Name = "Rick Riordan" }
        );

            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    Title = "Pride and Prejudice",
                    Year = 1813,
                    AuthorId = 1                   
                },
                new Book()
                {
                    Id = 2,
                    Title = "Northanger Abbey",
                    Year = 1817,
                    AuthorId = 1
                },
                new Book()
                {
                    Id = 3,
                    Title = "David Copperfield",
                    Year = 1850,
                    AuthorId = 2
                },
                new Book()
                {
                    Id = 4,
                    Title = "Don Quixote",
                    Year = 1617,
                    AuthorId = 3
                },
                 new Book()
                 {
                     Id = 5,
                     Title = "Harry Potter",
                     Year = 2000,
                     AuthorId = 4
                 },
                  new Book()
                  {
                      Id = 6,
                      Title = "The Firm",
                      Year = 1999,
                      AuthorId = 5
                  },
                   new Book()
                   {
                       Id = 7,
                       Title = "Percy Jackson",
                       Year = 2005,
                       AuthorId = 6
                   }
                );
        }
    }
}
