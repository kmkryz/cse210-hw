using System;


public abstract class Shape
{
    protected string _color = "";


    public Shape(string color)
    {
        this._color = color;


    }



    public string GetColor()
    {
       return _color;

    }

    public void SetColor(string color){
        this._color = color;
    }


    public abstract double GetArea();





}
