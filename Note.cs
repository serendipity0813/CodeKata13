using System;

public class Note
{
    public delegate void MyDelegate();

    public event MyDelegate MyEvent;

    public void TestMethod()
    {
        MyDelegate myDelegate1 = new MyDelegate(MyMethod1);
        MyDelegate myDelegate2 = new MyDelegate(MyMethod1);
        myDelegate1();
        myDelegate2();

        MyEvent += MyMethod1;
        MyEvent();

        MyEvent += MyMethod2;
        MyEvent();

        MyEvent += MyMethod3;
        MyEvent();

        Action myAction = new Action(() => Console.WriteLine("Hello, world!"));
        myAction();

        Func<int,int> myFunc = new Func<int,int>(x => x * x);
        int result = myFunc(10);
        Console.WriteLine(result);

    }
    public void MyMethod1()
    {
        Console.WriteLine("1");
    }

    public void MyMethod2()
    {
        Console.WriteLine("2");
    }
    public void MyMethod3()
    {
        Console.WriteLine("3");
    }
}