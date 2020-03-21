using System;
using System.Collections.Generic;
using System.Text;

namespace z1v1
{
    class Human
    {
        private int _age = 0, _weight = 0, _height = 0;
        private string _name;
        public Human(int age, int weight, int height, string name)
        {
            Age = age;
            Weight = weight;
            Height = height;
            Name = name;
        }
        public Human()
        {

        }
       // ~Human()
        //{
            //   Console.WriteLine($"{_name} commited suicide");
        //}
        public int Age
        {
            set
            {
                if (value >= 120 || value <= 0) throw new InvalidOperationException();
                else
                    _age = value;
            }
            get => _age;
        }
        public int Weight
        {
            set
            {
                if (value >= 1000 || value <= 0) throw new InvalidOperationException();
                else
                    _weight = value;
            }
            get => _weight;
        }
        public int Height
        {
            set
            {
                if (value >= 300 || value <= 0) throw new InvalidOperationException();
                else
                    _height = value;
            }
            get => _height;
        }
        public string Name
        {
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (!(value[i] >= 'A' && value[i] <= 'Z') && !(value[i] >= 'a' && value[i] <= 'z'))
                        throw new InvalidOperationException();

                if (value.Length == 0) throw new InvalidOperationException();
                _name = value;
            }
            get => FixName(_name);
        }
        static public string FixName(string value)
        {
            StringBuilder name = new StringBuilder();
            if (value[0] >= 'A' && value[0] <= 'Z') name.Append(value[0]);
            else name.Append((char)(value[0]-'a'+'A'));

            for (int i = 1; i < value.Length; i++)
                if (value[i] >= 'A' && value[i] <= 'Z') name.Append((char)(value[i] - 'A' + 'a'));
                else name.Append(value[i]);
            return (name.ToString());
        }
        public void OutInfo()
        {
            Console.WriteLine("*********");
            Console.WriteLine($"Name = {_name}\nAge = {_age}\nWeight = {_weight}\nHeigth = {_height}");

        }

    }
}
