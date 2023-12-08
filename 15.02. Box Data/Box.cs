using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double _lenght;
    private double _width;
    private double _height;

    public Box(double lenght, double width, double height)
    {
        this.Lenght = lenght;
        this.Width = width;
        this.Height = height;
    }
    public double Lenght
    {
        get { return this._lenght; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Lenght cannot be zero or negative.");
            }

            this._lenght = value;
        }
    }

    public double Width
    {
        get { return this._width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            this._width = value;
        }
    }

    public double Height
    {
        get { return this._height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this._height = value;
        }
    }

    public double SurfaceArea()
    { 
        return 2 * this.Lenght * this.Width + 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
    }
    public double Volume()
    {
        return this.Lenght * this.Width * this.Height;
    }

    public override string ToString()
    {
        return $"Surface Area – {this.SurfaceArea():f2}{Environment.NewLine}Volume – {this.Volume():f2}";
    }
}
