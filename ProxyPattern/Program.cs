using ProxyPattern;
using ProxyPattern.SubjectService;

var client = new Client();
            
Console.WriteLine("Client: Executing the client code with a real subject:");
var subjectService = new SubjectService();
client.ClientCode(subjectService);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
var proxy = new SubjectProxyService(subjectService);
client.ClientCode(proxy);