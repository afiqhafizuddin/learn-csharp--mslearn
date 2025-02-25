﻿// Arrray: Store sequences of values in a single data struture, Zero-based numeric index to access each elemant in an array

// Declaring arrays

string[] fraudulentOrderIDs = new string[3]; 
// string[] tells the compiler that 'fraudulentOrderIDs will be an array that stores string data type. 
// second set of square brackets tells the compiler that the array holds 3 elements

// declaring array with int data type
int[] jerseysNumbers = new int[8];


// Assigning values to elements on an array

fraudulentOrderIDs[0] = "A980";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D098";

// Retrieve values of an array

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassign the value of an array

fraudulentOrderIDs[1] = "B876";

Console.WriteLine($"Reassign Second Element: {fraudulentOrderIDs[1]}");

// Initialize an array

string[] fraudulentOrderIDs2 = { "A258", "B789", "C652", "D854", "E145"};

Console.WriteLine($"2nd Array First: {fraudulentOrderIDs2[0]}");
Console.WriteLine($"2nd Array Second: {fraudulentOrderIDs2[1]}");
Console.WriteLine($"2nd Array Third: {fraudulentOrderIDs2[2]}");
Console.WriteLine($"2nd Array Fourth: {fraudulentOrderIDs2[3]}");
Console.WriteLine($"2nd Array Fifth: {fraudulentOrderIDs2[4]}");

// Getting the size of an array

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders from first array and\n{fraudulentOrderIDs2.Length} fraudulent orders from second array.");

// Foreach statement

// Loopig thru an array using Foreach

int total = 0;
string[] names = { "Anders Hejlberg", "Bjarne Stratroup", "Brandon Eich", "Guido von Rossum"};
foreach (string name in names) 
{   
    // Console.WriteLine(name);
    total += 1;
}

Console.WriteLine(total);


int sum = 0;
int bin = 0; 

int[] inventory = { 200, 450, 650, 580, 700};
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory\n");


// Challenge 
Console.WriteLine("// CHALLENGE");

string[] orderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string order in orderID)
{
    // Console.WriteLine(order);
    if (order.StartsWith("B"))
    {
        Console.WriteLine(order);
    }
}