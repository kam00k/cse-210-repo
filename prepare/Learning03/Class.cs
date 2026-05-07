//Jack Wilson
//CSE210
//Encapsulation Learning Activity

public class Fraction
{
    //Create numerator and denominator attributes
    private int _numerator;
    private int _denominator;

    //default constructor
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;    
    }

    //constructor with 1 parameter
    public Fraction(int numer)
    {
        _numerator = numer;
        _denominator = 1;    
    }

    //constructor with 2 parameters
    public Fraction(int numer, int denom)
    {
        _numerator = numer;
        _denominator = denom;
    }
    
    //Returns the numerator value
    public int GetNumerator()
    {
        return _numerator;
    }

    //Returns the denominator value
    public int GetDenominator()
    {
        return _denominator;
    }

    //Sets the numerator value
    public void SetNumerator(int setNum)
    {
        _numerator = setNum;
    }
    
    //Sets the denominator value
    public void SetDenominator(int setDenom)
    {
        _denominator = setDenom;
    }

    //builds the fraction in string form and returns it
    public string GetFractionString()
    {
        return ($"{_numerator}/{_denominator}");
    }

    //calculates the fraction's decimal value and returns it.
    public double GetDecimalValue()
    {
        return (double) _numerator / (double) _denominator;
    }
}