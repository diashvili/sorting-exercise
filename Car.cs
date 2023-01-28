namespace G15_11102022_Sort;

internal class Car : IComparable<Car>
{
	public string? Model { get; set; }
	public int Speed { get; set; }

	public int CompareTo(Car? other)
	{
		if (other == null) throw new ArgumentNullException(nameof(other));

		if (this.Speed > other.Speed)
			return 1;
		if (this.Speed < other.Speed)
			return -1;

		return 0;
	}

	public override string ToString()
	{
		return $"{Model} - {Speed}";
	}
}