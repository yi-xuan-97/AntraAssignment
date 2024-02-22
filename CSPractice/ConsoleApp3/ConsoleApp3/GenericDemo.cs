namespace ConsoleApp3;

// public static class GenericDemo <T> where T: class - reference type
// public static class GenericDemo<T> where T : struct  --value type
// public static class GenericDemo<T> where T : enum - value
public static class GenericDemo<T>  // -- both value and reference type
{
    // public static bool AreEqual(int a, int b)
    // {
    //     return a.Equals(b);
    // }
    //
    // public static bool AreEqual(double a, double b)
    // {
    //     return a.Equals(b);
    // }

    // public static bool AreEqual(object a, object b)
    // {
    //     return a.Equals(b);
    // }


    //Short for Type
    public static bool AreEqual(T a, T b)
    {
        return a.Equals(b);
    }
    
}