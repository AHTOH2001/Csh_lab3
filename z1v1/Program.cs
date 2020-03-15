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

            /*   
               Console.WriteLine("Enter amount of sportsmans");
               int n = Convert.ToInt32(Console.ReadLine());
               Random rnd = new Random(n);
               string[] spr = { "Basketball", "Foolball", "Voleyball", "Light athletic", "Programming", "Chess" };
               string[] nme = { "vasya", "kolya", "vitya", "vikusha", "boris", "genadiy", "anton" };
               List<Sportsman> sportsmans = new List<Sportsman>();
               for (int i = 0; i < n; i++)
               {
                   sportsmans.Add(new Sportsman());
                   try
                   {
                       sportsmans[i].Age = rnd.Next() % 100 + 1;
                       sportsmans[i].Height = rnd.Next() % 300 + 1;
                       sportsmans[i].Weight = rnd.Next() % 200 + 1;
                       sportsmans[i].Name = nme[rnd.Next() % nme.Length];
                       int m = rnd.Next() % 5;
                       for (int j = 0; j < m; j++)
                           sportsmans[i][spr[rnd.Next() % spr.Length]] = new Sportsman.Award(rnd.Next() % 5, rnd.Next() % 5, rnd.Next() % 5);
                   }
                   catch
                   {
                       Console.WriteLine("Error");
                       return;
                   }
               }

               sportsmans.Sort();
               for (int i = 0; i < n; i++)
                   sportsmans[i].Out_info();

               Sportsman.Award y = new Sportsman.Award(3, 5, 7);// Sportsman.SetAwards(3, 5, 7);
               */
            Human human = new Human(14,89,130,"Liza");

            //Sportsman srt = new Sportsman(human,new Sportsman.SpecificSport());
            Sportsman.SpecificSport srt = new Sportsman.SpecificSport();
            //srt.Out_info();
            Console.WriteLine(srt.Sport);


            //Console.WriteLine(sportsmans[0] > sportsmans[1]);


        }
    }
}

