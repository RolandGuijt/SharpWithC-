using System.Numerics;

double[] doubles = new[] { 1.5, 2.1, 3.7, 4.1 };
var doubleSum = AddAll(doubles);
int[] integers = new[] { 1, 2, 3, 4, 5 };
var sum = AddAll(integers);

//All numeric types now implement INumber
//Inspect INumber and INumberBase
T AddAll<T>(T[] values)
    where T : INumber<T>
{
    T result = T.Zero;
    T one = T.One;
    T max = T.Max(result, one);
    T abs = T.Abs(result);

    foreach (var value in values)
        result += value;

    return result;
}

