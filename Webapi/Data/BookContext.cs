using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Freelibrary.Webapi.Models;

namespace Freelibrary.Webapi.Data
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Freelibrary.Webapi.Models.Book> Book { get; set; }
    }
}