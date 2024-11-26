// Create an array:

int[] a = [1, 2, 3, 4, 5, 6, 7, 8];

// Create a span
Span<int> b = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];

int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];
//spread operator
int[] single = [.. row0, .. row1, .. row2];
foreach (var element in single)
{
    Console.Write($"{element}, ");
}

int Total(int[] numbers)
{
    return numbers.Sum();
}

Total([45, 34, 75, 34]);

int TotalE(IEnumerable<int> numbers)
{
    return numbers.Sum();
}

var array = new int[34, 76, 43];
TotalE([45, 34, 75, 34, ..array]);
