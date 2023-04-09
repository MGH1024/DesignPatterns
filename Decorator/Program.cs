using Decorator;
using Decorator.Components;
using Decorator.Decorators;



Client client = new Client();

var simple = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
client.ClientCode(simple);
Console.WriteLine();

// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator2);

//https://refactoring.guru/design-patterns/decorator/csharp/example
//https://www.dntips.ir/post/2019/%d8%a2%d8%b4%d9%86%d8%a7%db%8c%db%8c-%d8%a8%d8%a7-%d8%a7%d9%84%da%af%d9%88%db%8c-%d8%b7%d8%b1%d8%a7%d8%ad%db%8c-decorator
