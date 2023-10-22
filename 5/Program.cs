﻿public class MyArray
{
    private int[] array;

    public MyArray(int[] values)
    {
        array = values;
    }

    public int this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value;
        }
    }

    public static bool operator ==(MyArray arr1, MyArray arr2)
    {
        return arr1.array.SequenceEqual(arr2.array);
    }

    public static bool operator !=(MyArray arr1, MyArray arr2)
    {
        return !arr1.array.SequenceEqual(arr2.array);
    }

    public static MyArray operator +(MyArray arr1, MyArray arr2)
    {
        if (arr1.array.Length != arr2.array.Length)
        {
            throw new InvalidOperationException("Arrays must have the same length.");
        }

        int[] resultArray = new int[arr1.array.Length];
        for (int i = 0; i < arr1.array.Length; i++)
        {
            resultArray[i] = arr1[i] + arr2[i];
        }
        return new MyArray(resultArray);
    }
}
