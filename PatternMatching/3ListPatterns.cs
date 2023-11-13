﻿var ints = new int[] { 4, 6, 8, 9 };

if (ints is [4, 6, 8, 9])
    Console.WriteLine("match");

//with discard pattern
if (ints is [4, 6, 8, _])
    Console.WriteLine("match");


//with slice pattern
if (ints is [4, 6, ..])
    Console.WriteLine("match");

//with var pattern
if (ints is [4, 6, .. var rest])
    Console.WriteLine("match");

//with relational pattern
if (ints is [< 5, > 6, _, ..])
    Console.WriteLine("match");

ReadOnlySpan<char> s = "Pluralsight";

if (s is ['P' or 'p', .. { Length: 9 }, 't'])
    Console.WriteLine("match");
