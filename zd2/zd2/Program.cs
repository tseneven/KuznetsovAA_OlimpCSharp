using System;
using System.IO;
using System.Security.Cryptography;

namespace zd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1;
            string line2;
            string line3;
            int n;
            char[] result;

            string mes = "";
            try
            {
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    line1 = sr.ReadLine();
                    line2 = sr.ReadLine();
                    line3 = sr.ReadLine();
                    line1 = line1.ToUpper();
                    line2 = line2.ToUpper();
                    line3 = line3.ToUpper();
                    n = line1.Length;
                    result = new char[n];
                    if(line1.Length != line2.Length || line1.Length != line3.Length || line2.Length != line3.Length)
                    {
                        mes = "Длина всех строк должна быть равной";
                    }
                    if (line1.Length > 255 || line2.Length > 255|| line3.Length > 255)
                    {
                        mes = "Длина cтроки не должна привышать 255";
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if (Convert.ToByte(line1[i]) > Convert.ToByte(line2[i]))
                        {
                            if (Convert.ToByte(line1[i]) > Convert.ToByte(line3[i]))
                            {
                                result[i] = line1[i];
                            }
                            else
                            {
                                result[i] = line3[i];
                            }
                        }
                        else
                        {
                            if (Convert.ToByte(line2[i]) > Convert.ToByte(line3[i]))
                            {
                                result[i] = line2[i];
                            }
                            else
                            {
                                result[i] = line3[i];
                            }
                        }

                    }

                }

                if(mes.Length > 0)
                {
                    using (StreamWriter sw = new StreamWriter("output.txt"))
                    {
                        sw.WriteLine(mes);
                    }

                }
                else
                {
                    using (StreamWriter sw = new StreamWriter("output.txt"))
                    {
                        sw.WriteLine(result);
                    }

                }

            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    sw.WriteLine($"Произошла ошибка {ex.Message}");
                }
            }

        }
    }
}
