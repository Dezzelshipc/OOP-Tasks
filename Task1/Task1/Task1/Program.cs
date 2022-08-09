using System;
//
namespace ConsoleApp1
{
    interface IQuackStrategy
    {
        void quack();
    }

    class NormalQuack : IQuackStrategy
    {
        public void quack()
        {
            Console.WriteLine("quack");
        }
    }

    class SilentQuack : IQuackStrategy
    {
        public void quack()
        {
        }
    }

    interface ISwimStrategy
    {
        void swim();
    }

    class NoramlSwim : ISwimStrategy
    {
        public void swim()
        {
            Console.WriteLine("swim");
        }
    }

    class CuteSwim : ISwimStrategy
    {
        public void swim()
        {
            Console.WriteLine("cute swimming!");
        }
    }

    class NoSwim : ISwimStrategy
    {
        public void swim()
        {
        }
    }

    interface IFlyStrategy
    {
        public void fly();
    }

    class NormalFly : IFlyStrategy
    {
        public void fly()
        {
            Console.WriteLine("i am flying!");
        }
    }

    class NoFly : IFlyStrategy
    {
        public void fly()
        {
            Console.WriteLine("i can't fly :'(");
        }
    }

    interface IDisplay
    {
        public void display();
    }

    class Display : IDisplay
    {
        private string _display;

        public Display(string display)
        {
            _display = display;
        }

        public void display()
        {
            Console.WriteLine(this._display);
        }
    }

    class Duck
    {
        private IQuackStrategy quackStrategy;
        private ISwimStrategy swimStrategy;
        private IFlyStrategy flyStrategy;
        private IDisplay display;

        public Duck(IQuackStrategy quackStrategy, ISwimStrategy swimStrategy, IFlyStrategy flyStrategy, IDisplay display)
        {
            this.quackStrategy = quackStrategy;
            this.swimStrategy = swimStrategy;
            this.flyStrategy = flyStrategy;
            this.display = display;
        }

        public void Quack()
        {
            quackStrategy.quack();
        }

        public void Swim()
        {
            swimStrategy.swim();
        }

        public void Fly()
        {
            flyStrategy.fly();
        }

        public void Display()
        {
            display.display();
        }
    }

    class Program
    {
        static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Swim();
            duck.Fly();
            duck.Display();
        }

        static void Main(string[] args)
        {
            Duck mallardDuck = new Duck(new NormalQuack(), new NoramlSwim(), new NormalFly(), new Display("I am mallard Duck"));
            Duck silentDuck = new Duck(new SilentQuack(), new CuteSwim(), new NoFly(), new Display("I am silent Duck"));

            TestDuck(mallardDuck);
            Console.WriteLine("\n");
            TestDuck(silentDuck);
        }
    }
}