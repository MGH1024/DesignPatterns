namespace ProxyPattern.SubjectService;

class SubjectProxyService : ISubjectService
{
    private readonly SubjectService _subjectService;
        
    public SubjectProxyService(SubjectService subjectService)
    {
        _subjectService = subjectService;
    }
    
    public void Request()
    {
        if (CheckAccess())
        {
            _subjectService.Request();
            LogAccess();
        }
    }

    private bool CheckAccess()
    {
        // Some real checks should go here.
        Console.WriteLine("Proxy: Checking access prior to firing a real request.");
        return true;
    }

    private void LogAccess()
    {
        Console.WriteLine("Proxy: Logging the time of request.");
    }
}