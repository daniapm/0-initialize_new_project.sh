using System;

class Shape
{
    public virtual int Area()
    {
       throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int wiedth;
    private int height;

    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
        }
    }

    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }
}