using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bykova41pPr5_2
{
    struct Data
    {
        public string day;
        public string month;
        public string year;
        public string slav;
        public string japan;

        public void show() // метод для вывода в консоль экземпляра структуры
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", day, month, year, slav, japan);
        }


        public string contact()
        {
            return day + ";" + month + ";" + year + ";" + slav + ";" + japan;
        }

    }
   
    class Program
    {
        

        static void getData(string path, List<Data> L)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] ar = sr.ReadLine().Split(';');
                    L.Add(new Data()
                    {
                        day = ar[0],
                        month = ar[1],
                        year = ar[2],
                       
                    });
                }
            }
        }

        static void gor(List<Data> L)
        {
            for (int i = 1; i < L.Count; i++)
            {
                Data u = L[i];
                int forParse = 0;

                if (u.day == "" || u.month == "" || !int.TryParse(u.day, out forParse) || !int.TryParse(u.month, out forParse))
                {
                    u.slav = "Нет данных для определения по cлавянскому гороскопу";
                }

                else if (Convert.ToInt32(u.day) <= 0 || Convert.ToInt32(u.day) > 31 || (Convert.ToInt32(u.day) > 28 && Convert.ToInt32(u.month) == 2) || Convert.ToInt32(u.month) <= 0 || Convert.ToInt32(u.month) > 12)
                {
                    u.slav = "Нет данных для определения по cлавянскому гороскопу";
                }

                else
                {
                    if ((Convert.ToInt32(u.month) == 12 && Convert.ToInt32(u.day) >= 24 && Convert.ToInt32(u.day) <= 31) || (Convert.ToInt32(u.month) == 1 && Convert.ToInt32(u.day) <= 30))
                    {
                        u.slav = "Вам покравительствует языческое божество Мороз";
                    }
                    else if ((Convert.ToInt32(u.month) == 1 && Convert.ToInt32(u.day) == 31) || (Convert.ToInt32(u.month) == 2 && Convert.ToInt32(u.day) <= 28))
                    {
                        u.slav = "Вам покравительствует языческое божество Велес";
                    }
                    else if ((Convert.ToInt32(u.month) == 3 && Convert.ToInt32(u.day) <= 31))
                    {
                        u.slav = "Вам покравительствует языческое божество Макошь";
                    }
                    else if ((Convert.ToInt32(u.month) == 4 && Convert.ToInt32(u.day) <= 30))
                    {
                        u.slav = "Вам покравительствует языческое божество Жива";
                    }
                    else if ((Convert.ToInt32(u.month) == 5 && Convert.ToInt32(u.day) <= 14))
                    {
                        u.slav = "Вам покравительствует языческое божество Ярило";
                    }
                    else if ((Convert.ToInt32(u.month) == 5 && Convert.ToInt32(u.day) >= 15 && Convert.ToInt32(u.day) <= 31) || (Convert.ToInt32(u.month) == 6 && Convert.ToInt32(u.day) <= 2))
                    {
                        u.slav = "Вам покравительствует языческое божество Леля";
                    }
                    else if ((Convert.ToInt32(u.month) == 6 && Convert.ToInt32(u.day) >= 2 && Convert.ToInt32(u.day) <= 12))
                    {
                        u.slav = "Вам покравительствует языческое божество Кострома";
                    }
                    else if ((Convert.ToInt32(u.month) == 6 && Convert.ToInt32(u.day) >= 13 && Convert.ToInt32(u.day) <= 30) || (Convert.ToInt32(u.month) == 7 && Convert.ToInt32(u.day) <= 6))
                    {
                        u.slav = "Вам покравительствует языческое божество Додола";
                    }
                    else if ((Convert.ToInt32(u.month) == 7 && Convert.ToInt32(u.day) == 24))
                    {
                        u.slav = "Вам покравительствует языческое божество Иван Купало";
                    }
                    else if ((Convert.ToInt32(u.month) == 7 && Convert.ToInt32(u.day) >= 7 && Convert.ToInt32(u.day) <= 31))
                    {
                        u.slav = "Вам покравительствует языческое божество Лада";
                    }
                    else if ((Convert.ToInt32(u.month) == 8 && Convert.ToInt32(u.day) >= 1 && Convert.ToInt32(u.day) <= 28))
                    {
                        u.slav = "Вам покравительствует языческое божество Перун";

                    }
                    else if ((Convert.ToInt32(u.month) == 8 && Convert.ToInt32(u.day) >= 29 && Convert.ToInt32(u.day) <= 31) || (Convert.ToInt32(u.month) == 9 && Convert.ToInt32(u.day) <= 13))
                    {
                        u.slav = "Вам покравительствует языческое божество Сева";
                    }
                    else if ((Convert.ToInt32(u.month) == 9 && Convert.ToInt32(u.day) >= 14 && Convert.ToInt32(u.day) <= 27))
                    {
                        u.slav = "Вам покравительствует языческое божество Рожаница";
                    }
                    else if ((Convert.ToInt32(u.month) == 9 && Convert.ToInt32(u.day) >= 28 && Convert.ToInt32(u.day) <= 30) || (Convert.ToInt32(u.month) == 10 && Convert.ToInt32(u.day) <= 15))
                    {
                        u.slav = "Вам покравительствует языческое божество Сварожичи";
                    }
                    else if ((Convert.ToInt32(u.month) == 10 && Convert.ToInt32(u.day) >= 16 && Convert.ToInt32(u.day) <= 31) || (Convert.ToInt32(u.month) == 11 && Convert.ToInt32(u.day) <= 8))
                    {
                        u.slav = "Вам покравительствует языческое божество Морена";

                    }
                    else if ((Convert.ToInt32(u.month) == 11 && Convert.ToInt32(u.day) >= 9 && Convert.ToInt32(u.day) <= 28))
                    {
                        u.slav = "Вам покравительствует языческое божество Зима";
                    }
                    else if ((Convert.ToInt32(u.month) == 11 && Convert.ToInt32(u.day) >= 29 && Convert.ToInt32(u.day) <= 30) || (Convert.ToInt32(u.month) == 12 && Convert.ToInt32(u.day) <= 23))
                    {
                        u.slav = "Вам покравительствует языческое божество Карачун";
                    }
                    else 
                    {
                        u.slav = "";
                    }
                }
            }
        }





                static void entryFile(string path, List<Data> L)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (Data u in L)
                {
                    sw.WriteLine(u.contact());
                }
            }
        }
        static void printData(List<Data> L)
        {
            foreach (Data u in L)
            {
                u.show();
            }
        }

        static void Main(string[] args)
        {
            List<Data> Data = new List<Data>();
            getData("horoscopeSlavic.csv", Data);
            printData(Data);


        }
    }
}
