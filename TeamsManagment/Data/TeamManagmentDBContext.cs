using Microsoft.EntityFrameworkCore;
using TeamsManagment.Models;

namespace TeamsManagment.Data;

public class TeamManagmentDBContext : DbContext
{
    public DbSet<Member> Members { get; set; } = null!;

    public DbSet<Team> Teams { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\MSSQLLocalDB;Database=TeamManagementEF;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>().HasData(
            new Member { Id = 1001, Name = "Henk", Email = "henk@breda.nl", TeamId = 201 },
            new Member { Id = 1002, Name = "Tim", Email = "tim@breda.nl", TeamId = 201 },
            new Member { Id = 1003, Name = "Robbert", Email = "robbert@breda.nl", TeamId = 201 },
            new Member { Id = 1004, Name = "Paul", Email = "paul@breda.nl", TeamId = 201 },
            new Member { Id = 1005, Name = "Niek", Email = "Bart-Jan@breda.nl", TeamId = 201 },
            new Member { Id = 1006, Name = "Teun", Email = "Teun@breda.nl", TeamId = 201 },

            new Member { Id = 1007, Name = "Bart", Email = "bart@avans.nl", TeamId = 202 },
            new Member { Id = 1008, Name = "Joris", Email = "joris@avans.nl", TeamId = 202 },
            new Member { Id = 1009, Name = "Danny", Email = "danny@avans.nl", TeamId = 202 },
            new Member { Id = 1010, Name = "Lars", Email = "lars@avans.nl", TeamId = 202 },
            new Member { Id = 1011, Name = "Rob", Email = "rob@avans.nl", TeamId = 202 },
            new Member { Id = 1012, Name = "Dennis", Email = "dennis@avans.nl", TeamId = 202 },
            new Member { Id = 1013, Name = "Daniël", Email = "daniel@avans.nl", TeamId = 202 }
   );

        modelBuilder.Entity<Team>().HasData(
            new Team { Id = 201, Group = "Groep-A", Title = "Alpha Wolf Squadron" },
            new Team { Id = 202, Group = "Groep-B", Title = "Moviehub" },
            new Team { Id = 203, Group = "Groep-H", Title = "The Cool beans" },
            new Team { Id = 204, Group = "Groep-1", Title = "You snooze, you loose!" },
            new Team { Id = 205, Group = "Groep-2", Title = "Nachos" },
            new Team { Id = 206, Group = "Groep-3", Title = "3 front-end devs + 1 back-end dev" },
            new Team { Id = 207, Group = "Groep-4", Title = "Cinavas" }
            );
    }

}
