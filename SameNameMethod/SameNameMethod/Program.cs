using System;

class Program
{
    class A
    {
        // 通常メソッド
        internal void MyMethodA()
        {
            Console.WriteLine("I'm MyMethodA in class A.");
        }
        // 仮想メソッド
        internal virtual void MyMethodB()
        {
            Console.WriteLine("I'm MyMethodB in class A.");
        }
    }

    class B : A
    {
        // new付きメソッド
        internal new void MyMethodA()
        {
            Console.WriteLine("I'm MyMethodA in class B.");
        }
        // override付きメソッド
        internal override void MyMethodB()
        {
            Console.WriteLine("I'm MyMethodB in class B.");
        }
    }

    static void Main()
    {
        // objは型B
        B obj = new B();
        // objTypeAは型A　(中味は同じ)
        A objTypeA = obj;
        obj.MyMethodA();
        objTypeA.MyMethodA();
        obj.MyMethodB();
        objTypeA.MyMethodB();
    }
}
