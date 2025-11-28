using System;
using System.Collections.Generic;
using System.IO;

namespace zd3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int count;
            string mes = "";

            try
            {
                int[] n_rost;
                int[] m_rost;
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    n = int.Parse(sr.ReadLine());
                    string strn_rost = sr.ReadLine();
                    string[] strn_split_rost = strn_rost.Split(' ');
                    n_rost = new int[n];
                    for (int k = 0; k < strn_split_rost.Length; k++)
                    {
                        n_rost[k] = int.Parse(strn_split_rost[k]);
                        if (int.Parse(strn_split_rost[k]) > 2050 || int.Parse(strn_split_rost[k]) < 1000)
                        {
                            mes = "Диапазоны нарушены";
                        }

                    }
                    m = int.Parse(sr.ReadLine());
                    string strm_rost = sr.ReadLine();
                    string[] strm_split_rost = strm_rost.Split(' ');
                    m_rost = new int[m];
                    for (int k = 0; k < strm_split_rost.Length; k++)
                    {
                        m_rost[k] = int.Parse(strm_split_rost[k]);
                        if (int.Parse(strm_split_rost[k]) > 2050 || int.Parse(strm_split_rost[k]) < 1000)
                        {
                            mes = "Диапазоны нарушены";
                        }
                    }

                    Array.Sort(n_rost);
                    Array.Sort(m_rost);

                    List<int> list_nrost = new List<int>();
                    List<int> list_mrost = new List<int>();

                    if (n <= 0 || m <= 0 || n >= 100000 || m >= 100000)
                    {
                        mes = "Диапазоны нарушены";
                    }

                    for (int i = 0; i < m_rost.Length; i++)
                    {
                        list_mrost.Add(m_rost[i]);
                    }
                    for (int i = 0; i < n_rost.Length; i++)
                    {
                        list_nrost.Add(n_rost[i]);
                    }


                    count = 0;

                    for (int i = 0; i < list_nrost.Count - 1; i++)
                    {
                        for (int j = 0; j < list_mrost.Count - 1; j++)
                        {
                            if (n_rost[i] >= m_rost[j])
                            {
                                count++;
                                i++;
                            }

                        }
                    }
                }
                if (mes.Length > 0)
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
                        sw.WriteLine(count);
                    }

                }

            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    sw.WriteLine(ex.Message);
                }
            }
        }
    }
}
