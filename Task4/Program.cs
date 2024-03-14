class Program
{
    static void PrintNumbers(int m, int n)
    {
        if (m == n)
        {
            Console.Write(m);
        }
        else
        {
            Console.Write(m + ", ");
            PrintNumbers(m + 1, n);
        }
    }

    static void Main()
    {
        int M = 1;
        int N = 5;

        Console.Write($"M = {M}; N = {N} -> ");
        PrintNumbers(M, N);
        
        M = 4;
        N = 8;

        Console.Write($"\nM = {M}; N = {N} -> ");
        PrintNumbers(M, N);
    }
}



