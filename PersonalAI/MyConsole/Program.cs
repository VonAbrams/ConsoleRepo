using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;
using BookStore;
using ItemStore;
using MyConsole.Shop;
using MyConsole.FileFinderFolder;
using MyConsole.Interfaces;
using MyConsole;
using static MyConsole.Utils;

public delegate void Del(int i, double j);
public delegate void NewDel();
public delegate void ItemDel(int i);
//public delegate Func<string> StringFunc();
public class MainHubClass
{

    internal class Coffee { }
    internal class Bacon { }
    internal class Eggs { }
    internal class Toast { }

    public static void Main(string[] args)
    {
        BookDB bookDB = new BookDB();
        ItemDB itemDB = new ItemDB();
        AddItems(itemDB);

        //System.Console.WriteLine(itemDB.GenerateTotal(GenerateSubTotal, CalculateLevelDiscount, DiscountMessage));

        var path = @"C:\Users\Student\Documents\games";


        bool isKnightAwake = false;
        bool isArcherAwake = true;
        bool isPrisonerAwake = false;
        bool isDogPresent = true;
        QuestLogic.CanFreePrisoner(isKnightAwake, isArcherAwake, isPrisonerAwake, isDogPresent);


        System.Console.WriteLine("Process Complete.");


        System.Console.WriteLine("Press any key");
        Console.ReadLine();

    }

    public class Lasagna
    {

        public int ExpectedMinsInOven()
        {
            return 40;
        }

        public int PreparationTimeInMins(int layers)
        {
            return layers * 2;
        }

        public int RemainingMinsInOven(int mins)
        {
            int expectedMins = ExpectedMinsInOven();
            return expectedMins % mins;
        }

        public int ElapsedTimeInMins(int layers, int mins)
        {
            int doneTime = RemainingMinsInOven(layers) + PreparationTimeInMins(mins);
            return doneTime;
        }
    }




    static decimal CalculateLevelDiscount(List<Item> discountedItems, decimal subTotal)
    {
        if (subTotal > 100)
        {
            return subTotal * 0.80M;
        }
        else
        {
            return subTotal;
        }

    }

    static void DiscountMessage(string message)
    {
        System.Console.WriteLine(message);
    }
    static void PrintTitles(Book b)
    {
        System.Console.WriteLine($"{b.Title}");
    }

    static void GenerateSubTotal(decimal subTotal)
    {
        System.Console.WriteLine("This is the total of your items " + subTotal);
    }

    static void AddBooks(BookDB bookDB)
    {
        bookDB.AddBook("Harry Potter", "J.K Rowlings", 19.95m, true);
        bookDB.AddBook("Intro to Programming", "John D Prog", 39.95m, true);
        bookDB.AddBook("Into the Void", "Books Authorson", 129.95m, false);
        bookDB.AddBook("Fake Books", "Guy Books", 12.00m, true);
    }

    static void AddItems(ItemDB itemDB)
    {
        itemDB.AddItem("Apple", 1.95m);
        itemDB.AddItem("Grapes", 1.00m);
        itemDB.AddItem("Pants", 19.95m);
        itemDB.AddItem("Shoes", 20.99m);
    }

    static void PrintItems(Item item)
    {
        System.Console.WriteLine($"{item.itemName}");
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



class Unit : Person
{
    string? unitFirstName { get; set; }
    string? unitLastName { get; set; }
    string? unitFullName { get; }

    string? unitEmailAddress { get; set; }
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

    public void canMove()
    {
        System.Console.WriteLine("I can move!");
    }

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