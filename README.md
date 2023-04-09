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
 1-create loosly copupling . <br/>
 2-create layering in projects.<br/>
 3-clients don't know about subsystems.<br/>
 4-reduce dependencies.<br/>
 5-there is no force to use facade for clients.<br/>
 
 
 
 you can find this patern in this repository [Facade pattern](https://github.com/MeysamGhiasvand/DesignPatterns/tree/master/Facade).


### Singleton Design pattern
Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

#### Tips
1- can use with lazy loading. <br/>
2- Its better to create singleton class as a sealed class. <br/>
3- for crate inheritence between singleton class and its child you should use protected constructor. <br/>


#### pros 
 1-you can ensure that project made just one instance of that class. <br/>
 2-singleton instances just initiate in the first use. <br/>
 3-we can use  singleton pattern for create limited number of instances. for example 5 instances. <br/>
 
 #### cons
 1-create tightly coupling . <br/>
 2- we can't transfer singleton ability to inherited classess.<br/>
 
 
 
 you can find this patern in this repository [Singleton pattern](https://github.com/MeysamGhiasvand/DesignPatterns/tree/master/Singleton).
