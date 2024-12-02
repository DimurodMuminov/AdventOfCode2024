internal class Program1
{
    //Day 1
    private static void main()
    {
        int result = ReadData1();

        Console.WriteLine(result);
        Console.WriteLine("-------------------");
    }
    
    private static int ReadData1()
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
                    int a = int.Parse(arr[0]);
                    int b = int.Parse(arr[3]);

                    list1.Add(a);
                    list2.Add(b);
                }
            }

            list1.Sort();
            list2.Sort();
            /*
             *Day 1 part1
            for (int i=0;i<list2.Count;i++)
            {
                result+=Math.Abs(list1.ElementAt(i)-list2.ElementAt(i));
            }
            */

            //Day 1 part 2

            int count = 0;
            bool change = false;

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        count++;
                        change = true;
                    }
                    else if (change)
                    {
                        break;
                    }
                }
                result += (count * list1[i]);
                count = 0;
                change = false;
                //
            }
        }
        catch
        {
        }
        return result;
    }
}