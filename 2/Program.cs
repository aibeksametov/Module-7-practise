public class MyArray
{
    private int[] array;

    public MyArray(int[] values)
    {
        array = values;
    }

    public int Sum()
    {
        return array.Sum();
    }

    public static bool operator <(MyArray arr1, MyArray arr2)
    {
        return arr1.Sum() < arr2.Sum();
    }

    public static bool operator >(MyArray arr1, MyArray arr2)
    {
        return arr1.Sum() > arr2.Sum();
    }
}
