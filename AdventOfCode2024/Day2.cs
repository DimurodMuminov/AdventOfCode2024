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

                    /*
                    //Part 1
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
                    }*/


                    //Part 2


                    int rm_index = 0;

                    while (rm_index < report.Length)
                    {
                        int[] report1= new int[report.Length-1];
                        int j = 0;

                        for(int i=0; i<report.Length;i++)
                        {
                            if(i!=rm_index)
                            {
                                report1[j]=report[i];
                                j++;
                            }
                        }
                        rm_index++;

                        increased = false;
                        decrased = false;
                        safe = true;

                        for (int i = 0; i < report1.Length - 1; i++)
                        {
                            if (Math.Abs(report1[i] - report1[i + 1]) > 3 || report1[i] == report1[i + 1])
                            {
                                safe = false;
                                break;
                            }
                            if (report1[i] < report1[i + 1])
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
                            break;
                        }
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

