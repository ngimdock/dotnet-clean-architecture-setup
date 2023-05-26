using Domain.Abstractions;
using Microsoft.EntityFrameworkCore;



public sealed class ApplicationDbContext: DbContext, IUnitOfWork {

  public ApplicationDbContext(DbContextOptions options): base(options) 
  {}

  protected override void OnModelCreating(ModelBuilder modelBuilder) => 
    modelBuilder.ApplyConfigurationFromAssembly(typeof(ApplicationDbContext).Assembly);
}