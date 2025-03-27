namespace Shape
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(false, "red", 1, 2);

			Shape[] shapes =
			{
				rectangle,
				new Square(true, "blue", 1, 1),
				new Circle("black", 5),
				new Rectangle(false, "yellow", 3, 4),
				new Square(false, "green", 6, 6)
			};

			foreach (var item in shapes)
			{
				item.aceInTheHole();
				Console.WriteLine(item);
			}

			Shape newShape = Rectangle.RectOrSquare(false, "purple", 4, 4);

			
        	}
	}
}
