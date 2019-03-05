using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int[] h = new int[34];
                char[] ch = new char[34];
                Random rand = new Random();
                for (int i = 0; i < 34; i++)
                {
                    h[i] = rand.Next(1072, 1103);

                }
                for (int k = 0; k < 34; k++)
                {
                    for (int i = 0; i < 34; i++)
                    {
                        for (int j = i + 1; j < 33; j++)
                        {
                            if (h[i] == h[j])
                            {
                                h[j] = 38;
                            }
                        }
                    }
                    
                    for (int i = 0; i < 34; i++)
                    {
                        for (int j = i + 1; j < 33; j++)
                        {
                            if (h[i] == h[j])
                            {
                                h[j] = rand.Next(1072, 1103);
                            }
                        }
                    }
                }
                for (int i = 0; i < 34; i++)
                {
                    ch[i] = Convert.ToChar(h[i]);
                }


               
            
            char[,] ss = new char[2, 17];
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        if (i == 0)
                        {
                            ss[i, j] = ch[j];
                        }
                        if (i == 1)
                        {
                            ss[i, j] = ch[j + 17];
                        }
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        Console.Write(ss[i,j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Введите шифруемое слово");
                StringBuilder str =new StringBuilder(Console.ReadLine());
                Console.Clear();
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        Console.Write(ss[i, j]);
                    }
                    Console.WriteLine();
                }
                int val = str.Length;
                StringBuilder str2 = new StringBuilder();
                Console.WriteLine("Зашифрованое слово:");
                for (int t = 0; t < val; t++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 17; j++)
                        {
                            
                            if (str[t] == ss[i,j])
                            {
                                if (i == 0)
                                {
                                    str2.Insert(t,Convert.ToString(ss[1, j]));    
                                }
                                if (i == 1)
                                {
                                    str2.Insert(t, Convert.ToString(ss[0, j]));
                                }

                            }
                        }
                    }
                }
                Console.WriteLine(str2);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            }
    }
}
