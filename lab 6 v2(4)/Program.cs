class Program
{
    static void Main()
    {
        GraphicsEditor editor = new GraphicsEditor();

        Circle circle = new Circle(10, 10, 5);
        Rectangle rectangle = new Rectangle(20, 20, 8, 12);
        Triangle triangle = new Triangle();
        Group group = new Group();

        group.AddElement(circle);
        group.AddElement(rectangle);

        editor.AddElement(circle);
        editor.AddElement(rectangle);
        editor.AddElement(triangle);
        editor.AddElement(group);

        Console.WriteLine("Original:");
        editor.DrawAll();

        editor.MoveAll(5, 5);
        Console.WriteLine("\nAfter Move:");
        editor.DrawAll();

        editor.ScaleAll(2);
        Console.WriteLine("\nAfter Scale:");
        editor.DrawAll();
    }
}
