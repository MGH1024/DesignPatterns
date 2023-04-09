namespace ProxyPattern.SubjectService;

public class SubjectService : ISubjectService
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}