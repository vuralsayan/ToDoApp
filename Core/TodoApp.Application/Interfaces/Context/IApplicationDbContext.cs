using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Tag> Tags { get; set; }
        DbSet<Todo> Todos { get; set; }
    }
}
