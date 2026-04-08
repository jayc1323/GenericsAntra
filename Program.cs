// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using GenericsAntra;

Console.WriteLine("Hello, World!");
/*04 Generics
Test your Knowledge
1. Describe the problem generics address.
 --> Allows polymorphic classes so that classes can have type parameters and can be instantiated at runtime with different types .
     Allows for code reuse and .
2. How would you create a list of strings, using the generic List class?
--> List<string> myList = new List<string>();
3. How many generic type parameters does the Dictionary class have?
--> 2, one for the key and one for the value.
4. True/False. When a generic class has multiple type parameters, they must all match.
--> false 
5. What method is used to add items to a List object?
--> The Add() method is used to add items to the List Object.
6. Name two methods that cause items to be removed from a List.
--> Remove() and RemoveAll() and RemoveAt()
7. How do you indicate that a class has a generic type parameter?
--> You use angle brackets <> after the class name and specify the type parameter inside the brackets. For example: class MyClass<T> { }
8. True/False. Generic classes can only have one generic type parameter.
--> False
9. True/False. Generic type constraints limit what can be used for the generic type.
--> True 
10. True/False. Constraints let you use the methods of the thing you are constraining to.
Yes
--> */
MyStack<string> stringStack = new MyStack<string>();
try
{
    stringStack.Push("String1");
    stringStack.Push("String2");
    Console.WriteLine("Num items in stack is {0}", stringStack.Count());
    stringStack.Pop();
    stringStack.Pop();
    stringStack.Pop();

}
catch(Exception e)
{
    Console.WriteLine(e.ToString());
}

GenericRepository<User> gr = new GenericRepository<User>();
gr.Add(new User("Jay"));
gr.Add(new User("Antra"));
gr.Add(new User("Dave"));
IEnumerable<User> users = gr.GetAll();
foreach(User u in users){
    Console.WriteLine($"User name is {u.Name},User id is {u.Id}");
    }


public class User : Entity
{ static int id = 0;
    public string Name { get;  }
    public int Id { get; }

    public User(string Name)
    {
        this.Name = Name;
        this.Id = id++;
        
    }

}

