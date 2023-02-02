class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }
    public Fraction(){}

    public Fraction(int numerator, int denominator)
    {
        int gcd = this.gcd(numerator, denominator);
        Numerator = numerator/gcd;
        Denominator = denominator/gcd;
    }

    public int gcd(int a, int b)
    {
        if (b == 0) return a;
        else return gcd(b, a % b);
    }

    public void DisplayFraction()
    {
        Console.WriteLine($"Fraction: {Numerator}/{Denominator}");
    }

    public void DisplayAsDecimal()  
    {
        double dec = (double)Numerator / Denominator;
        Console.WriteLine($"Decimal: {dec.ToString("F2")}");
    }

    public void AddTwoFractions(Fraction b)
    {
        int sumNumerator = this.Numerator * b.Denominator + this.Denominator * b.Numerator;
        int sumDenominator = this.Denominator * b.Denominator;
        Fraction sum = new Fraction(sumNumerator, sumDenominator);
        sum.DisplayFraction();
    }

    public void SubtractTwoFractions(Fraction b)
    {
        int subNumerator = this.Numerator * b.Denominator - this.Denominator * b.Numerator;
        int subDenominator = this.Denominator * b.Denominator;
        Fraction sub = new Fraction(subNumerator, subDenominator);
        sub.DisplayFraction();
    }

    public void MultiplyTwoFractions(Fraction b)
    {
        int mulNumerator = this.Numerator * b.Numerator;
        int mulDenominator = this.Denominator * b.Denominator;
        Fraction mul = new Fraction(mulNumerator, mulDenominator);
        mul.DisplayFraction();
    }

    public void DivideTwoFractions(Fraction b)
    {
        if (b.Numerator == 0) Console.WriteLine("Cannot divide 0");
        else
        {
            int divNumerator = this.Numerator * b.Denominator;
            int divDenominator = this.Denominator * b.Numerator;
            Fraction div = new Fraction(divNumerator, divDenominator);
            div.DisplayFraction();
        }
    }
    public static void Main()
    {
        Fraction a = new Fraction(2, 3);
        Console.WriteLine("Fraction A");
        a.DisplayFraction();
        a.DisplayAsDecimal();
        Fraction b = new Fraction(3, 2);
        Console.WriteLine("Fraction B");
        b.DisplayFraction();
        b.DisplayAsDecimal();
        Console.WriteLine("Add");
        a.AddTwoFractions(b);
        Console.WriteLine("Sub");
        a.SubtractTwoFractions(b);
        Console.WriteLine("Multiply");
        a.MultiplyTwoFractions(b);
        Console.WriteLine("Divide");
        a.DivideTwoFractions(b);
    }
}