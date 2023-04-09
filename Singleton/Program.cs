﻿// The client code.

using Singleton;

var s1 = MainSingleton.GetInstance();
var s2 = MainSingleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}