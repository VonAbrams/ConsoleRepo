using System;
using System.Globalization;

namespace FileLibrary;

public delegate void Del(int i, double j);
public delegate void NewDel();
public delegate void LibraryDel();
//public delegate Func<string> StringFunc();
public class MainHubClass
{

    public static void Main(string[] args)
    {

        Action<string> unitAction;

        Unit unit1 = new Unit();
        Unit unit2 = new Unit();

        unitAction = unit1.TestUnitAction;
        unitAction("Action Baby!!!");

        unitAction = unit2.TestUnitAction;
        unitAction("Hot girl shit");



        System.Console.WriteLine("Press any key");
        Console.ReadLine();

    }
}

class Publisher
{
    public event EventHandler<CustomEventsClass> RaiseMyEvent;

    public void DoSomething()
    {
        System.Console.WriteLine("This is me doing something.");
        OnRaiseMyEvent(new CustomEventsClass("Event Triggered."));
    }

    protected virtual void OnRaiseMyEvent(CustomEventsClass eventsClass)
    {
        EventHandler<CustomEventsClass> raiseEvent = RaiseMyEvent;
        if (raiseEvent != null)
        {
            eventsClass.Message += $"at {DateTime.Now}";
            raiseEvent(this, eventsClass);
        }
    }
}

class Subscriber
{
    private readonly string _id;

    public Subscriber(string id, Publisher publisher)
    {
        _id = id;
        publisher.RaiseMyEvent += HandleCustomEvent;
    }

    void HandleCustomEvent(object sender, CustomEventsClass args)
    {
        System.Console.WriteLine($"{_id} received this message: {args.Message}");
    }
}
class NewCollection<T>
{
    private T[] arr = new T[100];
    int nextIndex = 0;

    public T this[int i]
    {
        get => arr[i];
        set => arr[i] = value;
    }
}

class NextCollection<T>
{
    private T[] array = new T[100];

    public T this[int i]
    {
        get => array[i];
        set => array[i] = value;
    }
}

class MathClass
{
    public void DoThis()
    {
        System.Console.WriteLine("Void method");
    }

    public static void DoThat()
    {
        System.Console.WriteLine("Static method");
    }

    public void Multiplier(int x, double y)
    {
        System.Console.WriteLine(x * y + " ");
    }

    public void Adder(int x, double y)
    {
        System.Console.WriteLine(x + y + " ");
    }
}

class Unit : Person
{
    string? unitFirstName { get; set; }
    string? unitLastName { get; set; }

    string? unitFullName { get; }
    int? unitAge;
    public Unit()
    {
        unitFirstName = firstName;
        unitLastName = lastname;
        unitAge = age;
        unitFullName = unitFirstName + "" + unitLastName;

        SayFullName();
        Yell();
    }
    public static bool hasClearance1;
    public static Unit FindByTitle(String title)
    {
        return new Unit();
    }
    public void TestUnitAction(string message)
    {
        System.Console.WriteLine(message);
    }

    private bool GethasClearance()
    {
        return hasClearance1;
    }

    private void SethasClearance(bool value)
    {
        hasClearance1 = value;
    }

    public string GetFullName()
    {
        return unitFullName;
    }

    public bool TestFunc(int num)
    {
        if (num < 5)
            return true;
        else
            return false;
    }
    public void SayFullName()
    {
        System.Console.WriteLine($"I am {unitFullName}");
    }
    public static void Yell()
    {
        if (hasClearance1)
            System.Console.WriteLine("I have clearance");
        else
            System.Console.WriteLine("I don't have clearance");
    }
}
public class Person
{
    public string? firstName { get; set; }
    public string? lastname { get; set; }

    public int? age { get; set; }

}

public class ClientDB
{

}
public class CustomEventsClass : EventArgs
{
    public CustomEventsClass(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}