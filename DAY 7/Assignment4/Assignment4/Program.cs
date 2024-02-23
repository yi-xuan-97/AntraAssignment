using Assignment4;
using Assignment4.Repositories;


// Create an instance of MyStack<int> and test its methods
MyStack<int> stackInt = new MyStack<int>();
MyStack<string> stackString = new MyStack<string>();
MyStack<double> stackDouble = new MyStack<double>();


// Push something onto the stack
// stackInt.Push(1);
// stackString.Push("string1");
// stackString.Push("string2");
// stackDouble.Push(3.21);
// stackDouble.Push(3.22);
// stackDouble.Push(3.23);
//
// // Print the count of elements in the stack
// Console.WriteLine("Count: " + stackInt.Count());
// Console.WriteLine("Count: " + stackString.Count());
// Console.WriteLine("Count: " + stackDouble.Count());
//
// // Pop elements from the stack and print them
// Console.WriteLine("Popped item: " + stackInt.Pop());
// Console.WriteLine("Popped item: " + stackString.Pop());
// Console.WriteLine("Popped item: " + stackDouble.Pop());


// // Create an instance of MyList<int> and test its methods
// MyList<int> myList = new MyList<int>();
//
// // Add some elements to the list
// myList.Add(10);
// myList.Add(20);
// myList.Add(30);
//
// // Print the elements of the list
// Console.WriteLine("Elements of the list:");
// for (int i = 0; i < myList.Count(); i++)
// {
//     Console.WriteLine(myList.Find(i));
// }
//
// // Remove an element from the list
// int removedElement = myList.Remove(1);
// Console.WriteLine("\nRemoved element: " + removedElement);
//
// // Print the elements of the list after removal
// Console.WriteLine("\nElements of the list after removal:");
// for (int i = 0; i < myList.Count(); i++)
// {
//     Console.WriteLine(myList.Find(i));
// }
//
// // Check if the list contains a specific element
// Console.WriteLine("\nDoes the list contain 20? " + myList.Contains(20));
//
// // Clear the list
// myList.Clear();
// Console.WriteLine("\nList cleared. Count: " + myList.Count());


// Create an instance of GenericRepository<Entity> and test its methods
IRepostory<Entity> repository = new GenericRepository<Entity>();

// Add some entities
repository.Add(new Entity { Id = 1 });
repository.Add(new Entity { Id = 2 });

// Get all entities and print their ids
Console.WriteLine("All entities:");
foreach (var entity in repository.GetAll())
{
    Console.WriteLine(entity.Id);
}

// Get an entity by id and print its id
Console.WriteLine("\nEntity with Id=2:");
Entity entityById = repository.GetById(2);
if (entityById != null)
{
    Console.WriteLine(entityById.Id);
}

// Remove an entity
repository.Remove(entityById);

// Save changes
repository.Save();










