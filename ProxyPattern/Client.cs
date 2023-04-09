using ProxyPattern.SubjectService;

namespace ProxyPattern;

public class Client
{
    public void ClientCode(ISubjectService subject)
    {
        subject.Request();
    }
}