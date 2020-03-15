using System;
using System.Collections.Generic;

namespace z1v1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Human human1 = new Human(19, 61, 181, "Antoha");
             human1.Age = 10;
             human1.Out_info();
             Sportsman Grisha = new Sportsman();

             Grisha["Football"] = Sportsman.SetAwards(5, 2, 6);
             Grisha["Basketball"] = Sportsman.SetAwards(-1, 1, 3);
             // Grisha.suicide();
             //Grisha.Award = "Garmon";
             Grisha.Out_info();
             Sportsman Vitek = new Sportsman
             {
                 Name = "Vyacheslav",
                 Age = 24,
                 Height = 187,
                 Weight = 89
             };
             Vitek["Chess"] = Sportsman.SetAwards(15, 0, 0);
             Vitek.Out_info();
             Grisha.Out_info();
             Vitek["Chess"] = Sportsman.SetAwards(3, 4, 5);
             Vitek.Out_info();
             try
             {
                 Vitek.Age = 5;
             }
             catch
             {
                 Console.WriteLine("Wrong age");
                 return;
             }
             int x = 6;
             if (x == 6)
             {
                 Sportsman guy = new Sportsman();
                 guy.Age = 6;
                 guy.Out_info();
             }*/


            Console.WriteLine("Enter amount of sportsmans");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random(n);
            string[] spr = { "Basketball", "Foolball", "Voleyball", "Light athletic", "Programming", "Chess" };
            string[] nme = { "vasya", "kolya", "vitya", "vikusha", "boris", "genadiy", "anton" };
            List<Sportsman> sportsmans = new List<Sportsman>();
            for (int i = 0; i < n; i++)
            {
                Human human;
                try
                {
                    human = new Human(age: rnd.Next() % 100 + 1,
                                            weight: rnd.Next() % 300 + 1,
                                            height: rnd.Next() % 200 + 1,
                                            name: nme[rnd.Next() % nme.Length]);
                }
                catch
                {
                    Console.WriteLine("Error");
                    return;
                }


                int m = rnd.Next() % 5;
                SpecificSport[] mas = new SpecificSport[m];
                for (int j = 0; j < m; j++)
                    mas[j] = new SpecificSport(new SpecificSport.Awards(rnd.Next() % 5, rnd.Next() % 5, rnd.Next() % 5), spr[rnd.Next() % spr.Length]);

                sportsmans.Add(new Sportsman(human, mas));
                //sportsmans[i][spr[rnd.Next() % spr.Length]] = new Sportsman.Award(rnd.Next() % 5, rnd.Next() % 5, rnd.Next() % 5);

            }

            sportsmans.Sort();
            for (int i = 0; i < n; i++)
                sportsmans[i].Out_info();
        
            //SpecificSport.Award y = new Sportsman.Award(3, 5, 7);// Sportsman.SetAwards(3, 5, 7);

            /*Human human = new Human(14,89,130,"Liza");

            Sportsman srt = new Sportsman(human,new SpecificSport(new SpecificSport.Awards(),"Gandball"));
            //   SpecificSport srt = new SpecificSport();
            //srt.Out_info();
            srt.Out_info();


            //Console.WriteLine(sportsmans[0] > sportsmans[1]);
            */
            
        }
    }
}

