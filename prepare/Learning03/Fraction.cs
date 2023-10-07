
using System;
using System.Xml.Schema;

public class Fraction {
    private int _top;
    private int _bottom;


    public Fraction (){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }


    //Getters and setters
    // public int GetNumerator(){
    //     return _top;
    // }

    // public void SetNumerator(int numerator){
    //     _top = numerator;
    // }

    // public int GetDenominator(){
    //     return _bottom;
    // }

    //     public void SetDenominator(int denominator){
    //     _top = denominator;
    // }

    public string GetString(){

        return $"{_top}/{_bottom}";
    }


    public double GetDecimal(){

        return (double)_top/(double)_bottom;
    }
}

