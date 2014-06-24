namespace CakeDecorator
{
    public class ChocolateCake : ICake
    {
        public double GetPrice() { return 1.5; }

        public string Desc { get { return "Chocolate Cake"; } }
        public string Name { get { return "C"; } }

        public string GetCakeName()
        {
            return Name;
        }
    }

    public class WhiteCake : ICake
    {
        public double GetPrice() { return 1; }

        public string Desc { get { return "White Cake"; } }
        public string Name { get { return "W"; } }
    }

    public interface ICake
    {
        double GetPrice();
        string Desc { get; }
    }

    public abstract class Toppings : ICake
    {
        private readonly ICake _cake;

        protected Toppings(ICake cake) { _cake = cake; }

        public virtual double GetPrice() { return _cake.GetPrice(); }

        public virtual string Desc { get { return _cake.Desc; } }
    }

    public class Sprinkles : Toppings
    {
        public Sprinkles(ICake cake) : base(cake) { }

        public override double GetPrice() { return base.GetPrice() + 1; }

        public override string Desc { get { return base.Desc + " with Sprinkles"; } }

        public string GetCakeName()
        {
            return Name + "S";
        }
    }

    public class Topper : Toppings
    {
        public Topper(ICake cake) : base(cake) { }

        public override double GetPrice() { return base.GetPrice() + 2; }
    }
}