using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebAPi.Context;

public class DataContext : DbContext
{
    //Gerecia a conexãocom o banco de dados
    public DataContext(DbContextOptions<DataContext> options) : base(options){}

    //Relaciona 
    public DbSet<Book>? Book { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        var book = modelBuilder.Entity<Book>();    

    }
}