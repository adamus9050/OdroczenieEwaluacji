using System;

// Definicja delegata Func, który zwraca wartość typu T
public delegate T Func<T>();

// Definicja klasy Lazy<T>, która reprezentuje odroczoną ewaluację wartości typu T
public class Lazy<T>
{
    private bool evaluated = false;
    private T value;
    private Func<T> func;

    public Lazy(Func<T> func)
    {
        this.func = func;
    }

    public T Eval()
    {
        if (!evaluated)
        {
            value = func();
            evaluated = true;
        }
        return value;
    }
}
namespace Maediator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Przykładowe użycie
            Lazy<int> n = new Lazy<int>(() => 3 + 4); // utworzenie obiektu Lazy<int> z odroczoną ewaluacją wyrażenia 3 + 4

            Console.WriteLine(n.Eval()); // wyświetlenie wyniku ewaluacji wyrażenia 3 + 4, czyli 7
            Console.ReadLine();
        }
    }
}