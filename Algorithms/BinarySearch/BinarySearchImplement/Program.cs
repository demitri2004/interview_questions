using BinarySearchImplement;

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var search = new BinarySearch();

bool result = search.recursive(arr, 11);
Console.WriteLine(11 + " = " + result);

bool result1 = search.recursive(arr, 1);
Console.WriteLine(1 + " = " + result1);

bool result2 = search.recursive(arr, 5);
Console.WriteLine(5 + " = " + result2);

bool result3 = search.recursive(arr, 9);
Console.WriteLine(9 + " = " + result3);

bool result4 = search.recursive(arr, 20);
Console.WriteLine(20 + " = " + result4);

Console.WriteLine("***************");



bool result5 = search.iterative(arr, 11);
Console.WriteLine(11 + " = " + result5);

bool result7 = search.iterative(arr, 1);
Console.WriteLine(1 + " = " + result7);

bool result8 = search.iterative(arr, 5);
Console.WriteLine(5 + " = " + result8);

bool result9 = search.iterative(arr, 9);
Console.WriteLine(9 + " = " + result9);

bool result10 = search.iterative(arr, 20);
Console.WriteLine(20 + " = " + result10);

