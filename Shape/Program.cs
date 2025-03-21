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
				new Circle("black", 5)
				

			};

        }
	}
}
