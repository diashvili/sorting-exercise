namespace G15_11102022_Sort;

internal class ArrayHelper
{
	public static void Sort<T>(T[] array, Func<T, T, int> comparer)
	{
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array.Length - i - 1; j++)
			{
				if (comparer(array[j], array[j + 1]) == 1)
				{
					(array[j], array[j + 1]) = (array[j + 1], array[j]);
				}
			}
		}
	}

	public static void Sort<T>(T[] array) where T : IComparable<T>
	{
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array.Length - i - 1; j++)
			{
				if (array[j].CompareTo(array[j + 1]) == 1)
				{
					(array[j], array[j + 1]) = (array[j + 1], array[j]);
				}
			}
		}
	}
}