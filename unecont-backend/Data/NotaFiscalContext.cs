using Microsoft.EntityFrameworkCore;
using NotaFiscalApi.Models;

namespace NotaFiscalApi.Data;

public class NotaFiscalContext : DbContext
{
    public DbSet<NotaFiscal> NotasFiscais => Set<NotaFiscal>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=notas.db");
}