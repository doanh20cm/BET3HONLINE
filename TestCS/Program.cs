class Program
{

    static int Nhap(int index)
    {
        int n;
        Console.Write("nums[{0}] = ", index);
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Nhap lai nums[{0}] = ", index);
        }
        return n;
    }

    static void Main(string[] args)
    {
        var nums = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            nums.Add(Nhap(i));
        }
        var result = nums.Where(
            n => n % 2 == 1 && n > 5)
            .OrderByDescending(n => n).ToList();
    }
}