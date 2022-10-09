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
            for (int i = 0; i < L.Count; i++)
            {
                Data u = L[i];
                int fp = 0;

                if (u.day == "" || u.month == "" || !int.TryParse(u.day, out fp) || !int.TryParse(u.month, out fp))
                {
                    u.slav = "Нет данных для определения по cлавянскому гороскопу | ";
                }

                else if (Convert.ToInt32(u.day) <= 0 || Convert.ToInt32(u.day) > 31 || (Convert.ToInt32(u.day) > 28 && Convert.ToInt32(u.month) == 2) || Convert.ToInt32(u.month) <= 0 || Convert.ToInt32(u.month) > 12)
                {
                    u.slav = "Нет данных для определения по cлавянскому гороскопу | ";
                }

                else
                {

                    if ((Convert.ToInt32(u.month) == 1 && Convert.ToInt32(u.day) == 31) || (Convert.ToInt32(u.month) == 2 && Convert.ToInt32(u.day) <= 28))
                    {
                        u.slav = "Вам покравительствует языческое божество Велес | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 3 && Convert.ToInt32(u.day) <= 31))
                    {
                        u.slav = "Вам покравительствует языческое божество Макошь | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 4 && Convert.ToInt32(u.day) <= 30))
                    {
                        u.slav = "Вам покравительствует языческое божество Жива | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 5 && Convert.ToInt32(u.day) <= 14))
                    {
                        u.slav = "Вам покравительствует языческое божество Ярило | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 5 && Convert.ToInt32(u.day) >= 15 && Convert.ToInt32(u.day) <= 31) || (Convert.ToInt32(u.month) == 6 && Convert.ToInt32(u.day) <= 2))
                    {
                        u.slav = "Вам покравительствует языческое божество Леля | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 6 && Convert.ToInt32(u.day) >= 2 && Convert.ToInt32(u.day) <= 12))
                    {
                        u.slav = "Вам покравительствует языческое божество Кострома | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 6 && Convert.ToInt32(u.day) >= 13 && Convert.ToInt32(u.day) <= 30) || (Convert.ToInt32(u.month) == 7 && Convert.ToInt32(u.day) <= 6))
                    {
                        u.slav = "Вам покравительствует языческое божество Додола | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 7 && Convert.ToInt32(u.day) == 24))
                    {
                        u.slav = "Вам покравительствует языческое божество Иван Купало | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 7 && Convert.ToInt32(u.day) >= 7 && Convert.ToInt32(u.day) <= 31))
                    {
                        u.slav = "Вам покравительствует языческое божество Лада | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 8 && Convert.ToInt32(u.day) >= 1 && Convert.ToInt32(u.day) <= 28))
                    {
                        u.slav = "Вам покравительствует языческое божество Перун | ";

                    }
                    else if ((Convert.ToInt32(u.month) == 8 && Convert.ToInt32(u.day) >= 29 && Convert.ToInt32(u.day) <= 31) || (Convert.ToInt32(u.month) == 9 && Convert.ToInt32(u.day) <= 13))
                    {
                        u.slav = "Вам покравительствует языческое божество Сева | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 9 && Convert.ToInt32(u.day) >= 14 && Convert.ToInt32(u.day) <= 27))
                    {
                        u.slav = "Вам покравительствует языческое божество Рожаница | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 9 && Convert.ToInt32(u.day) >= 28 && Convert.ToInt32(u.day) <= 30) || (Convert.ToInt32(u.month) == 10 && Convert.ToInt32(u.day) <= 15))
                    {
                        u.slav = "Вам покравительствует языческое божество Сварожичи | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 10 && Convert.ToInt32(u.day) >= 16 && Convert.ToInt32(u.day) <= 31) || (Convert.ToInt32(u.month) == 11 && Convert.ToInt32(u.day) <= 8))
                    {
                        u.slav = "Вам покравительствует языческое божество Морена | ";

                    }
                    else if ((Convert.ToInt32(u.month) == 11 && Convert.ToInt32(u.day) >= 9 && Convert.ToInt32(u.day) <= 28))
                    {
                        u.slav = "Вам покравительствует языческое божество Зима | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 11 && Convert.ToInt32(u.day) >= 29 && Convert.ToInt32(u.day) <= 30) || (Convert.ToInt32(u.month) == 12 && Convert.ToInt32(u.day) <= 23))
                    {
                        u.slav = "Вам покравительствует языческое божество Карачун | ";
                    }
                    else if ((Convert.ToInt32(u.month) == 12 && Convert.ToInt32(u.day) >= 24 && Convert.ToInt32(u.day) <= 31) || (Convert.ToInt32(u.month) == 1 && Convert.ToInt32(u.day) <= 30))
                    {
                        u.slav = "Вам покравительствует языческое божество Мороз | ";
                    }
                    else
                    {
                        u.slav = "Нет данных для определения по cлавянскому гороскопу | ";
                    }
                }
                if (u.year == "" || !int.TryParse(u.year, out fp))
                {
                    u.japan = "Нет данных для определения по японскому гороскопу";
                }
                else
                {
                    if (Convert.ToInt32(u.year) % 12 == 0)
                    {
                        u.japan = "По японскому календарю, Вы - обезьяна";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 1)
                    {
                        u.japan = "По японскому календарю, Вы - петух";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 2)
                    {
                        u.japan = "По японскому календарю, Вы - собака";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 3)
                    {
                        u.japan = "По японскому календарю, Вы - кабан";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 4)
                    {
                        u.japan = "По японскому календарю, Вы - крыса";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 5)
                    {
                        u.japan = "По японскому календарю, Вы - вол";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 6)
                    {
                        u.japan = "По японскому календарю, Вы - тигр";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 7)
                    {
                        u.japan = "По японскому календарю, Вы - кролик";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 8)
                    {
                        u.japan = "По японскому календарю, Вы - дракон";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 9)
                    {
                        u.japan = "По японскому календарю, Вы - змея";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 10)
                    {
                        u.japan = "По японскому календарю, Вы - лошадь";
                    }
                    else if (Convert.ToInt32(u.year) % 12 == 11)
                    {
                        u.japan = "По японскому календарю, Вы - овца";
                    }
                    else 
                    {
                        u.japan = "Нет данных для определения по японскому гороскопу";
                    }
                }
                L[i] = u;
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
            //printData(Data);
            gor(Data);
            printData(Data);

            entryFile("horoSJ.csv", Data);
        }
    }
}
       
    

