using System;

class Program
{

    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }

    public class Fraction
    {

        private int _top;
        private int _bottom;

        public Fraction()
        {
            //Default to 1/1
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        public string GetFractionString()
        {
            //Notice that this is not stored as a member variable
            //Is is just a temporary, local variable that will be recomputed each time this is called.
            string text = $"{_top}/{_bottom}";
            return text;
        }

        public double GetDecimalValue()
        {
            //Notice this is not stored as a member variable.
            //Is will be recomputed each time this is called.
            return (double)_top / (double)_bottom;
        }
        
    }
}