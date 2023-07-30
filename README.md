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


### YAGNI
YAGNI (You Ain't Gonna Need It) is a principle of Extreme Programming (XP) that suggests not to implement functionality until it is necessary.
 The idea is to avoid adding features or code that are not currently required, as it can lead to unnecessary complexity and maintenance overhead.
 Here's a simple example in C# to illustrate the YAGNI principle:

Let's say you are working on a simple class that represents a basic calculator, and you have implemented addition and subtraction methods: <br/>
[YAGNI](https://github.com/MGH1024/DesignPatterns/blob/master/SoftwareDesignPrinciples/Yagni/SimpleCalculatorWithYagni.cs).


Now, imagine that later on, you or your team members have a discussion and think that it might be a good idea to add a multiplication 
method to the calculator class, even though you don't have an immediate use case for it:
[Violation of YAGNI](https://github.com/MGH1024/DesignPatterns/blob/master/SoftwareDesignPrinciples/Yagni/SimpleCalculatorYagniViolation.cs).



At this point, adding the Multiply method violates the YAGNI principle. If you don't currently need the multiplication functionality 
in your application, you should avoid adding it to the class. Doing so introduces extra complexity to your codebase,
 increases the maintenance burden, and may even lead to bugs that could have been avoided.

Instead, you should wait until a legitimate requirement arises for multiplication in your application. By following 
the YAGNI principle, you keep your codebase focused and lean, making it easier to manage and understand. 
If and when you actually need the Multiply functionality, you can implement it at that time.


###  Cohesion 

Let's consider another example of cohesion by creating a class that represents a simple shopping cart for an online store. 
The goal is to keep related functionality together in the class to achieve high cohesion. <br/>

[Cohesion](https://github.com/MGH1024/DesignPatterns/blob/master/SoftwareDesignPrinciples/Cohesion.cs).


in this example, we have two classes: ShoppingCart and CartItem. The ShoppingCart class is responsible for managing the
items in the shopping cart, and it contains methods related to cart management. The CartItem class represents
an individual item in the cart, and it encapsulates the details of a product, including its name, price, and quantity.

The methods within the ShoppingCart class are highly cohesive as they all relate to the concept of a shopping cart 
and work together to manage the cart effectively:

1-AddItem: Adds a new item to the cart or updates the quantity if the item is already present.
2-RemoveItem: Removes an item from the cart based on the product name.
3-CalculateTotal: Calculates the total cost of all items in the cart.
4-DisplayCart: Displays the items in the cart along with the total cost.
By keeping these related functionalities together in the ShoppingCart class,
we ensure that the code is well-organized and easy to maintain. Any changes or enhancements to the shopping cart 
functionality can be handled within this class without affecting other parts of the application.



### Lazy Loading 

Lazy loading is a design pattern used to defer the loading of an object or resource until the point at which it is 
actually needed. This can help improve performance and reduce resource consumption by only loading objects when 
they are requested.

Let's consider a practical example of lazy loading in C# using a class that represents a customer and its associated 
orders. We'll use lazy loading to load the orders only when they are accessed, 
rather than loading them eagerly when the customer object is created.

[Lazy Loading](https://github.com/MGH1024/DesignPatterns/blob/master/SoftwareDesignPrinciples/LazyLoading/LazyLoading_Simple.cs).

In this example, the Customer class has a lazy-loaded property Orders. The first time the Orders property is accessed, 
it checks if the orders field is null (indicating that the orders haven't been loaded yet). If orders is null, 
it calls the private method LoadOrders() to load the orders from a database or some external source. Subsequent 
accesses to the Orders property will reuse the previously loaded orders.

Using lazy loading in this scenario ensures that the customer's orders are only loaded when they are needed,
not immediately when the Customer object is created. This can be especially beneficial when dealing with large 
amounts of data or expensive resource operations, as it reduces unnecessary upfront loading and potentially 
saves memory and processing time.


<br/><br/>
In Entity Framework (EF) Core, lazy loading is a feature that allows related entities to be automatically
loaded from the database when they are accessed for the first time. By default, EF Core performs eager loading,
which means it loads all related entities upfront when retrieving the main entity. However, lazy loading defers
the loading of related entities until they are explicitly accessed, which can be more efficient in certain scenarios.

Let's consider a practical example to understand lazy loading in EF Core:
Suppose we have two entities: Author and Book. Each Author can have multiple Books, 
and we want to use lazy loading to load the books of an author only when we access them.

[Lazy Loading in Ef](https://github.com/MGH1024/DesignPatterns/blob/master/SoftwareDesignPrinciples/LazyLoading/LazyLoading_Ef.cs).

In the above example, when we retrieve an Author from the database using EF Core (context.Authors.FirstOrDefault(...)),
the Books collection is not loaded immediately. It is only loaded when we access the Books property inside the 
foreach loop. This is what lazy loading does: deferring the loading of related entities until they 
are actually accessed.

It's important to note that to enable lazy loading, the Books property in the Author entity must be 
marked as virtual. Additionally, make sure that lazy loading is enabled in the DbContext configuration 
(optionsBuilder.UseLazyLoadingProxies()) as shown in the LibraryContext class.

Lazy loading can be very useful in scenarios where you have complex object graphs with multiple 
related entities, and you want to load only the data that is needed, reducing unnecessary database 
queries and improving performance. However, it's essential to be mindful of potential performance
issues, like the N+1 query problem, where lazy loading can result in numerous additional database 
queries if not used carefully. In such cases, explicit loading or eager loading may be more appropriate.




