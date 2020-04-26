using System;
using System.Collections.Generic;

namespace z1v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(29, 380, 193, "gRiSHa", true);
            human1.OutInfo();
            human1.Gender = false;
            human1.Height = 173;
            human1.Weight = 80;
            human1.Name = "Grishila";
            human1.DateOfBirth = new DateTime(1991, 02, 19); //but not 1991 year is forbidden;
            human1.OutInfo();
            Human human2 = new Human(new DateTime(2000, 05, 23), 52, 160, "Vikusha", false);
            human2.OutInfo();
        }
    }
}

