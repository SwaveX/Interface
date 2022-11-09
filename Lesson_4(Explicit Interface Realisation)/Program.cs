MyClass myClass = new MyClass();
Foo(myClass);
Bar(myClass);

Console.WriteLine();

MyOtherClass otherClass = new MyOtherClass();
Foo(otherClass);
Bar(otherClass);

///<summary>
/// How it 'works'
/// </summary>
//IFirstInterface firstInterface = otherClass;
//firstInterface.Action();

///<summary>
/// Possible way but it's risky
/// </summary>
//((IFirstInterface)otherClass).Action();
//((ISecondInterface)otherClass).Action();
//object obj = new object();        
//((IFirstInterface)obj).Action();      ERROR!


///<summary>
/// We can use as and is instead
/// </summary>
if (otherClass is IFirstInterface firstInterface)
{
    firstInterface.Action();
}
else
{
    Console.WriteLine("Sorry");
}

///<summary>
/// Yes we can realise 2 Interfaces with same method
/// If we need realise those methods for each interface then we must 
/// explicitly realise them (My English sucks...)
/// </summary>

static void Foo(IFirstInterface firstInterface)
{
    firstInterface.Action();
}

static void Bar(ISecondInterface secondInterface)
{
    secondInterface.Action();
}

interface IFirstInterface
{
    void Action();
}
interface ISecondInterface
{
    void Action();
}

class MyClass : IFirstInterface, ISecondInterface
{
    public void Action()
    {
        Console.WriteLine("MyClass Action...");
    }
}

class MyOtherClass : IFirstInterface, ISecondInterface
{
    void IFirstInterface.Action()
    {
        Console.WriteLine("MyOtherClass IFirstInterface  Action...");
    }

    void ISecondInterface.Action()
    {
        Console.WriteLine("MyOtherClass ISecondInterface Action...");
    }
}