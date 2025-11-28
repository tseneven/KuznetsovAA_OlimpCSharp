using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result;
                int res2;
                int res1;
                string mes = "";
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    string read = sr.ReadLine();

                    string[] read2 = read.Split(' ');

                    int n = int.Parse(read2[0].ToString());
                    int k1 = int.Parse(read2[1].ToString());
                    int t1 = int.Parse(read2[2].ToString());
                    int k2 = int.Parse(read2[3].ToString());
                    int t2 = int.Parse(read2[4].ToString());

                    int ost1 = (n % k1);
                    int ost2 = (n % k2);

                    if(n < 0 || n > 10000 || k1 < 0 || k1 > 10000 || k2 < 0 || k2 > 10000 ||t1 < 0 || t1 > 10000 || t2 < 0 || t2 > 10000)
                    {
                        mes = "Нарушен диапазон";
                    }

                    if (ost1 > 0)
                    {
                        res1 = (n / k1 + 1) * t1;
                        
                    }
                    else
                    {
                        res1 = (n / k1) * t1;
                    }
                    if (ost2 > 0)
                    {
                        res2 = (n / k2 + 1) * t2;

                    }
                    else
                    {
                        res2 = (n / k2) * t2;
                    }


                    result = Math.Min(res1, res2);                  
                }
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    sw.WriteLine(result);
                    sw.WriteLine(mes);
                }

            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    sw.WriteLine($"Произошла ошибка{ex.Message}");
                }

            }
        }
    }
}
