namespace Task3
{
    public interface IBeverage
    {
        public string getDescription();

        public int getCost();
    }

    public class Espresso : IBeverage
    {
        public int getCost()
        {
            return 100;
        }

        public string getDescription()
        {
            return "Espresso";
        }
    }

    public class Decaf : IBeverage
    {
        public int getCost()
        {
            return 300;
        }

        public string getDescription()
        {
            return "Decaf";
        }
    }

    public class HouseBlend : IBeverage
    {
        public int getCost()
        {
            return 255;
        }

        public string getDescription()
        {
            return "HouseBlend";
        }
    }

    public class DarkRoast : IBeverage
    {
        public int getCost()
        {
            return 199;
        }

        public string getDescription()
        {
            return "DarkRoast";
        }
    }

    public interface CondimentDecorator : IBeverage { }

    public class MilkDecorator : CondimentDecorator
    {
        IBeverage wrappedObject;

        public MilkDecorator(IBeverage wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }

        public string getDescription()
        {
            return wrappedObject.getDescription() + " with milk";
        }

        public int getCost()
        {
            return wrappedObject.getCost() + 51;
        }
    }

    public class SoyDecorator : CondimentDecorator
    {
        IBeverage wrappedObject;

        public SoyDecorator(IBeverage wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }

        public string getDescription()
        {
            return wrappedObject.getDescription() + " with soy";
        }

        public int getCost()
        {
            return wrappedObject.getCost() + 75;
        }
    }

    public class MochaDecorator : CondimentDecorator
    {
        IBeverage wrappedObject;

        public MochaDecorator(IBeverage wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }

        public string getDescription()
        {
            return wrappedObject.getDescription() + " with mocha";
        }

        public int getCost()
        {
            return wrappedObject.getCost() + 13;
        }
    }

    public class WhipDecorator : CondimentDecorator
    {
        IBeverage wrappedObject;

        public WhipDecorator(IBeverage wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }

        public string getDescription()
        {
            return wrappedObject.getDescription() + " with whip";
        }

        public int getCost()
        {
            return wrappedObject.getCost() + 25;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new MilkDecorator(new SoyDecorator(new MochaDecorator(new WhipDecorator(new Decaf()))));
            Console.WriteLine(beverage.getDescription());
            Console.WriteLine(beverage.getCost());

        }
    }
}