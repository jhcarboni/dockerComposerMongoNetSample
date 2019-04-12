using MongoDB.Driver;

namespace TodoApp.Models
{
    public interface ITodoContext
    {
        IMongoCollection<Todo> Todos { get; }
    }
}