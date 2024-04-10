using ApiCrud.estudantes;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data;

public class AppDbContext: DbContext
{
    private DbSet<Estudante> Estudantes { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Banco.sql");
        
        base.OnConfiguring(optionsBuilder);
    }
}