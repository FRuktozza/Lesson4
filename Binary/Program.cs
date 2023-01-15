class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        FillArray(ref array);
        
        int dec = BinDecode(array);
        Console.WriteLine(GoodPrint(array, dec));
    }

    static void FillArray(ref int[] array)
    {
        Random random = new Random();

        array[0] = 1;
        for (int i = 1; i < array.Length; i++)
        {
            array[i] = random.Next(0, 2);
        }
    }

    static int BinDecode(int[] bin)
    {
        int dec = 0;

        for (int i = 0; i < bin.Length; i++)
        {
            dec += bin[i] * (int) Math.Pow(2, bin.Length - i - 1);
        }

        return dec;
    }

    static string GoodPrint(int[] bin, int dec)
    {
        return $"{String.Join("", bin)} >> {dec}";
    }
}