namespace Assignment4.Repositories;

// Define an interface IEntity with common properties for entities
public interface IEntity
{
    int Id { get; set; }
}


// Define a class representing an entity
public class Entity : IEntity
{
    public int Id { get; set; }
}