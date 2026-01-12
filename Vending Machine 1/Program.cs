using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> vendingItems = CreateVendingItems();

        DisplayMenu(vendingItems);
        int choice = GetUserSelection();

        VendItem(vendingItems, choice);
    }

    static Dictionary<int, string> CreateVendingItems()
    {
        return new Dictionary<int, string>
        {
            { 1, "Doritos" },
            { 2, "Pepsi" },
            { 3, "Mini Donuts" },
            { 4, "Gatorade" }
        };
    }

    static void DisplayMenu(Dictionary<int, string> items)
    {
        Console.WriteLine("Free Vending Machine");
        Console.WriteLine("--------------------");

        foreach (var item in items)
        {
            Console.WriteLine($"{item.Key}. {item.Value}");
        }
    }

    static int GetUserSelection()
    {
        Console.Write("\nEnter the number of your selection: ");
        int selection;

        while (!int.TryParse(Console.ReadLine(), out selection))
        {
            Console.Write("Invalid input. Please enter a number: ");
        }

        return selection;
    }

    static void VendItem(Dictionary<int, string> items, int selection)
    {
        if (items.ContainsKey(selection))
        {
            Console.WriteLine($"\nVending {items[selection]}... Enjoy!");
        }
        else
        {
            Console.WriteLine("\nInvalid selection. Nothing vended.");
        }
    }
}
