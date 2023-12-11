﻿using System;
using Shapes;

public class Rectangle : IDrawable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    { 
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        DrawLine(this.width, '*', '*');
        for (int i = 1; i < this.height; i++)
        {
            DrawLine(this.width, '*', ' ');
        }
        DrawLine(this.width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < this.width - 1; ++i)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }
}