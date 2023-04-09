namespace Singleton;

// The Singleton class defines the `GetInstance` method that serves as an
// alternative to constructor and lets clients access the same instance of
// this class over and over.

// EN : The Singleton should always be a 'sealed' class to prevent class
// inheritance through external classes and also through nested classes.
public sealed class MainSingleton
{
    // The Singleton's constructor should always be private to prevent
    // direct construction calls with the `new` operator.
    private MainSingleton() { }

    // The Singleton's instance is stored in a static field.there are
    // multiple ways to initialize this field, all of them have various pros
    // and cons. In this example we'll show the simplest of these ways,
    // which, however, doesn't work really well in multi threaded program.
    private static MainSingleton _instance;

    // This is the static method that controls the access to the singleton
    // instance. On the first run, it creates a singleton object and places
    // it into the static field. On subsequent runs, it returns the client
    // existing object stored in the static field.
    public static MainSingleton GetInstance()
    { 
        //this implement lazy load singleton.
        return _instance ??= new MainSingleton();
    }

    // Finally, any singleton should define some business logic, which can
    // be executed on its instance.
    public void SomeBusinessLogic()
    {
        // ...
    }
}