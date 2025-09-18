
using System;

public class Fraction{
    // private attributes

    private int _top;
    private int _bottom;

    // the Constructors

    // *Constructor that has no parameters that initializes the number to 1/1.
    public Fraction(){
        _top = 1;
        _bottom =1;

    }

    // *Constructor that has one parameter for the top and that initializes the 
    // denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int numberTop){
        _top = numberTop;
        _bottom =1;
    }

    //Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }   

    // returns the fraction
    public string GetFractionString(){
        string texFraction = $"{_top}/{_bottom}";
        return  texFraction;

    } 

    //returns a double that is the result of dividing the top number by the bottom
    public double GetDecimalValue(){
        double result = (double)_top / (double)_bottom;
        return  result;
    }


}