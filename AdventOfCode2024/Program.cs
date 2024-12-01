internal class Program
{
    private static void Main(string[] args)
    {
        int result = ReadData();

        Console.WriteLine(result);
        Console.WriteLine("-------------------");
    }

    private static int ReadData()
    {
        int result=0;
        string filePath = "input.txt";

        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        try
        {
            using (StreamReader sr = System.IO.File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] arr = s.Split(' ');
                    int a=int.Parse(arr[0]);
                    int b=int.Parse(arr[3]);

                    list1.Add(a);
                    list2.Add(b);
                }
            }
            list1.Sort();
            list2.Sort();

            for (int i=0;i<list2.Count;i++)
            {
                result+=Math.Abs(list1.ElementAt(i)-list2.ElementAt(i));
            }

        }
        catch
        {
        }
        return result;
    }
}