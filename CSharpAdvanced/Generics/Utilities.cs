namespace Generics;

public class Utilities<T> where T : IComparable, new()
{
    // where T : IComparable - constraint to interface
    // where T: Product - constraint to class
     // where T: struct - value type
     // where T : class - reference type
     // where T : new() - has a default constructor

     public void DoSomething(T value)
     {
         var obj = new T();
     }
    public T Max(T a, T b)
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}
