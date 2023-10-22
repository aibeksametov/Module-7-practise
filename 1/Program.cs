public class MyClass
{
    public int Value { get; set; }

    public MyClass(int value)
    {
        Value = value;
    }

    public static bool operator ==(MyClass obj1, MyClass obj2)
    {
        return obj1.Value == obj2.Value;
    }

    public static bool operator !=(MyClass obj1, MyClass obj2)
    {
        return obj1.Value != obj2.Value;
    }

    public override bool Equals(object obj)
    {
        if (obj is MyClass myObj)
        {
            return this.Value == myObj.Value;
        }
        return false;
    }
}
