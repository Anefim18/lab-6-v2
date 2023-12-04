using System;
using System.Collections.Generic;

abstract class GraphicPrimitive
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();
    public abstract void Move(int x, int y);
    public abstract void Scale(float factor);
}

class Circle : GraphicPrimitive
{
    public int Radius { get; set; }

    public Circle(int x, int y, int radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Circle at ({X}, {Y}) with radius {Radius}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public override void Scale(float factor)
    {
        Radius = (int)(Radius * factor);
    }
}

class Rectangle : GraphicPrimitive
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Rectangle at ({X}, {Y}) with width {Width} and height {Height}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public override void Scale(float factor)
    {
        Width = (int)(Width * factor);
        Height = (int)(Height * factor);
    }
}

class Triangle : GraphicPrimitive
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing Triangle at ({X}, {Y})");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public override void Scale(float factor)
    {
        // Implement scaling logic for Triangle
    }
}

class Group : GraphicPrimitive
{
    private List<GraphicPrimitive> elements = new List<GraphicPrimitive>();

    public void AddElement(GraphicPrimitive element)
    {
        elements.Add(element);
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Group at ({X}, {Y})");
        foreach (var element in elements)
        {
            element.Draw();
        }
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        foreach (var element in elements)
        {
            element.Move(x, y);
        }
    }

    public override void Scale(float factor)
    {
        foreach (var element in elements)
        {
            element.Scale(factor);
        }
    }
}

class GraphicsEditor
{
    private List<GraphicPrimitive> elements = new List<GraphicPrimitive>();

    public void AddElement(GraphicPrimitive element)
    {
        elements.Add(element);
    }

    public void DrawAll()
    {
        foreach (var element in elements)
        {
            element.Draw();
        }
    }

    public void MoveAll(int x, int y)
    {
        foreach (var element in elements)
        {
            element.Move(x, y);
        }
    }

    public void ScaleAll(float factor)
    {
        foreach (var element in elements)
        {
            element.Scale(factor);
        }
    }
}

