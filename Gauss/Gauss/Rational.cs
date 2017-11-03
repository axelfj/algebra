public class Rational
{
    private int num;   
    private int den;   

    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new RuntimeException("Denominator is zero");
        }
        int g = gcd(numerator, denominator);
        num = numerator / g;
        den = denominator / g;
    }

    public String toString()
    {
        if (den == 1) return num + "";
        else return num + "/" + den;
    }

    public Rational times(Rational b){return new Rational(this.num * b.num, this.den * b.den);}


    public Rational plus(Rational b)
    {
        int numerator = (this.num * b.den) + (this.den * b.num);
        int denominator = this.den * b.den;
        return new Rational(numerator, denominator);
    }

    public Rational reciprocal() { return new Rational(den, num); }

    public Rational divides(Rational b){return this.times(b.reciprocal());}

    private static int gcd(int m, int n)
    {
        if (0 == n) return m;
        else return gcd(n, m % n);
    }
}
