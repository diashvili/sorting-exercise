namespace G15_11102022_Sort;

internal class Book
{
	public string? Title { get; set; }
	public double Price { get; set; }
	
	public override string ToString()
	{
		return $"{Title} - {Price}";
	}
}