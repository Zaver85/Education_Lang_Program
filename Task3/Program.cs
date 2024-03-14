class Program
{
    static void ReversePrint(int[] arr, int idx)
    {
        if (idx < 0)
            return;

        Console.Write(arr[idx] + " ");
        ReversePrint(arr, idx - 1);
    }

    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 5, 0, 10, 34 };

        ReversePrint(myArray, myArray.Length - 1);
    }
}
