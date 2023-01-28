// See https://aka.ms/new-console-template for more information

using G15_11102022_Sort;

Book[] books =
{
	new () { Title = "Book1", Price = 200 },
	new () { Title = "Book2", Price = 150 },
	new () { Title = "Book3", Price = 280 },
	new () { Title = "Book4", Price = 120 },
};

//Array.Sort(books);
ArrayHelper.Sort<Book>(books, BookComparer);

foreach (var book in books) Console.WriteLine(book);

static int BookComparer(Book book1, Book book2)
{
	if (book1.Price > book2.Price)
		return 1;
	if (book1.Price < book2.Price)
		return -1;

	return 0;
}

//Car[] cars =
//{
//	new () { Model = "Car1", Speed = 200 },
//	new () { Model = "Car2", Speed = 150 },
//	new () { Model = "Car3", Speed = 280 },
//	new () { Model = "Car4", Speed = 120 },
//};

////Array.Sort(cars);
//ArrayHelper.Sort<Car>(cars);

//foreach (var car in cars) Console.WriteLine(car);