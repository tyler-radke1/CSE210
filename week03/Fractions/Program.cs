using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        var defaultFraction = new Fraction();

        var secondFraction = new Fraction(top: 5);

        var thirdFraction = new Fraction(top: 75, bottom: 100);

        defaultFraction.SetBottom(value: 8);

        secondFraction.SetTop(value: 9);

        Console.WriteLine(thirdFraction.GetFractionString());

        Console.WriteLine(thirdFraction.GetDecimalValue());
        
    }
}