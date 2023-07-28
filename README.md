### Facade Design pattern
Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

#### Tips
1- simple implementation. <br/>
2- No limit in Number of facades. <br/>
3- you can use facade wit singleton design pattern. <br/>
4- you can use abstract facade for those facade class who have several implementation. <br/> 
5- create layering in projects with facade. <br/>
6- simplify crowded and complex systems. <br/>


#### pros and cons
 1-create loosely coupling . <br/>
 2-create layering in projects.<br/>
 3-clients don't know about subsystems.<br/>
 4-reduce dependencies.<br/>
 5-there is no force to use facade for clients.<br/>
 
 
 
 you can find this pattern in this repository [Facade pattern](https://github.com/MGH1024/DesignPatterns/tree/master/Facade).


### Singleton Design pattern
Singleton is a creation design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

#### Tips
1- can use with lazy loading. <br/>
2- Its better to create singleton class as a sealed class. <br/>
3- for crate inheritance between singleton class and its child you should use protected constructor. <br/>


#### pros 
 1-you can ensure that project made just one instance of that class. <br/>
 2-singleton instances just initiate in the first use. <br/>
 3-we can use  singleton pattern for create limited number of instances. for example 5 instances. <br/>
 
 #### cons
 1-create tightly coupling . <br/>
 2- we can't transfer singleton ability to inherited classes.<br/>
 
 
 
 you can find this pattern in this repository [Singleton pattern](https://github.com/MGH1024/DesignPatterns/tree/master/Singleton).



### Template Design pattern
The Template Method pattern is quite common in C# frameworks. Developers often use it to provide framework users with a simple <br/>
means of extending standard functionality using inheritance.<br/>

Identification: Template Method can be recognized if you see a method in base class that calls a bunch of other methods <br/>
that are either abstract or empty.<br/>




### KISS
KiSS stands for "Keep it Simple, Stupid," which is a principle that encourages keeping code simple, straightforward
and easy to understand. The idea is to avoid unnecessary complexity and convoluted solutions. Writing simple and clear 
code not only makes it easier for others to read and maintain but also reduces the likelihood of introducing bugs.
Let's illustrate the KiSS principle with a simple example: <br/>

we need to check if a given year is a leap year or not. A leap year is divisible by 4, but if it is also divisible <br/>
by 100, it must be divisible by 400 as well. We'll implement both a non-KiSS and a KiSS version to demonstrate <br/>
the difference in simplicity and clarity. <br/>


you can find this software design principle in this repository [KISS](https://github.com/MGH1024/DesignPatterns/blob/master/SoftwareDesignPrinciples/Kiss.cs).


In the non-KiSS example, the code contains nested if statements, making it slightly harder to read and understand the logic.  <br/>
In contrast, the KiSS example utilizes a single line to check the conditions for a leap year,   <br/>
which simplifies the code significantly. By eliminating the need for intermediate variables and nested conditions,  <br/>
the KiSS example adheres to the principle of keeping the code simple and straightforward. <br/>

Again, keep in mind that simplicity should not be pursued at the cost of readability or maintainability. <br/>
Always aim for code that is both simple and easy to understand, but also consider factors like code comments, <br/>
meaningful variable names, and clear logic to make your code more accessible to others.  <br/>
The KiSS principle is just one aspect of writing clean and maintainable code.<br/>
