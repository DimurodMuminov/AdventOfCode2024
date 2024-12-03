internal class Day3
{
    public static void day3()
    {

        Console.WriteLine("Day 3");
        int result = ReadData();

        Console.WriteLine(result);
        Console.WriteLine("-------------------");
    }
    private static int ReadData()
    {
        int result = 0;
        string filePath = "input.txt";

        bool calculate=true;

        try
        {
            //List <string> lines = new List <string>();
            using (StreamReader sr = System.IO.File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    // Part 1
                    /*  string s1 = "";
                      for (int i = 0; i < s.Length - 3; i++)
                      {
                          s1 = "";
                          s1 += s[i];
                          s1 += s[i + 1];
                          s1 += s[i + 2];
                          s1 += s[i + 3];

                          if (s1 == "mul(")
                          {
                              try
                              {
                                  string s2 = "";
                                  int index = i + 4;

                                  while (s[index] != ')')
                                  {
                                      s2 += s[index];
                                      index++;
                                  }
                                  string[] nums = s2.Split(',');

                                  if (nums.Length == 2)
                                  {
                                      int num1 = 0, num2 = 0;
                                      num1 = int.Parse(nums[0]);
                                      num2 = int.Parse(nums[1]);

                                      result += (num1 * num2);
                                  }

                              }
                              catch 
                              {
                                  //Console.WriteLine(e.Message);
                              }
                          }
                      }*/

                    // ----------------------------------------------
                    // Part 2

                    string s1 = "",calc="";

                    for (int i = 0; i < s.Length - 3; i++)
                    {
                        s1 = "";
                        calc = "";

                        s1 += s[i];
                        s1 += s[i + 1];
                        s1 += s[i + 2];
                        s1 += s[i + 3];

                        calc += s1;

                        if (calc =="do()")
                        {
                            calculate = true;
                        }

                        try
                        {
                            int index=i+ 4;
                            // don't() size=7
                            calc += s[index];
                            calc += s[index + 1];
                            calc += s[index + 2];
                        }
                        catch { }

                        if(calc =="don't()")
                        {
                            calculate = false;
                        }
                        
                        if (s1 == "mul(" && calculate)
                        {
                            try
                            {
                                string s2 = "";
                                int index = i + 4;

                                while (s[index] != ')')
                                {
                                    s2 += s[index];
                                    index++;
                                }
                                string[] nums = s2.Split(',');

                                if (nums.Length == 2)
                                {
                                    int num1 = 0, num2 = 0;
                                    num1 = int.Parse(nums[0]);
                                    num2 = int.Parse(nums[1]);

                                    result += (num1 * num2);
                                }

                            }
                            catch
                            {
                                //Console.WriteLine(e.Message);
                            }
                        }
                    }

                }
            }
        }
        catch(System.Exception e) 
        {
            Console.WriteLine(e.Message);
        }
        return result;
    }
}

