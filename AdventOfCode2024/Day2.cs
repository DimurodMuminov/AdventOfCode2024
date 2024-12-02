internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Day 2");
        int result = ReadData();

        Console.WriteLine(result);
        Console.WriteLine("-------------------");
    }

    private static int ReadData()
    {
        int count = 0;
        string filePath = "input.txt";
        
        //Part 1
        try
        {
            bool safe=true;
            bool increased=false,decrased=false;

            using (StreamReader sr = System.IO.File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] arr = s.Split(' ');
                    int[] report = new int[arr.Length];

                    for(int i=0; i<arr.Length; i++)
                    {
                        report[i]=int.Parse(arr[i]);
                    }

                    //checking
                    increased = false;
                    decrased = false;
                    safe = true;

                    for (int i = 0; i < report.Length - 1; i++)
                    {
                        if (Math.Abs(report[i] - report[i + 1]) > 3 || report[i] == report[i + 1])
                        {
                            safe = false;
                            break;
                        }
                        if (report[i] < report[i + 1])
                        {
                            increased = true;
                        }
                        else
                        {
                            decrased = true;
                        }

                        if (increased && decrased)
                        {
                            safe = false;
                            break;
                        }

                        if (safe == false)
                        {
                            break;
                        }
                    }
                    if (safe)
                    {
                        count++;
                    }
                }
            }

        }
        catch
        {
        }
        return count;
    }
}

