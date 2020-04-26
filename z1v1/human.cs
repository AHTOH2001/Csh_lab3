using System;
using System.Text;

namespace z1v1
{
    class Human
    {
        private int _weight, _height;
        private string _name;
        private DateTime _dateOfBirth;
        private bool _isValidDate = false;

        public Human(int age, int weight, int height, string name, bool gender)
        {
            Age = age;
            Weight = weight;
            Height = height;
            Name = name;
            Gender = gender;
        }
        public Human(DateTime dateOfBirth, int weight, int height, string name, bool gender)
        {
            DateOfBirth = dateOfBirth;
            Weight = weight;
            Height = height;
            Name = name;
            Gender = gender;
        }
        public bool Gender { get; set; }
        public DateTime DateOfBirth
        {
            set
            {
                if (DateOfBirth.Year != 1 && value.Year != DateOfBirth.Year) throw new FieldAccessException("You cannot change date of birth");
                if (value.Year > DateTime.Now.Year || DateTime.Now.Year - value.Year >= 120) throw new IndexOutOfRangeException("Invalid age");
                _isValidDate = true;
                _dateOfBirth = value;
            }
            get => _dateOfBirth;
        }
        public int Age
        {
            private set
            {
                DateOfBirth = new DateTime(DateTime.Now.Year - value, 1, 1);
                _isValidDate = false;
            }
            get => (int)((DateTime.Now.Ticks - DateOfBirth.Ticks) / 316224000000000);
        }
        public int Weight
        {
            set
            {
                if (value >= 1000 || value <= 0) throw new IndexOutOfRangeException("Invalid weight");
                _weight = value;
            }
            get => _weight;
        }
        public int Height
        {
            set
            {
                if (value >= 300 || value <= 0) throw new IndexOutOfRangeException("Invalid Height");
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
                        throw new IndexOutOfRangeException("Invalid name");

                if (value.Length == 0) throw new IndexOutOfRangeException("Invalid name");
                _name = value;
            }
            get => FixName(_name);
        }
        static public string FixName(string value)
        {
            StringBuilder name = new StringBuilder();
            if (value[0] >= 'A' && value[0] <= 'Z') name.Append(value[0]);
            else name.Append((char)(value[0] - 'a' + 'A'));

            for (int i = 1; i < value.Length; i++)
                if (value[i] >= 'A' && value[i] <= 'Z') name.Append((char)(value[i] - 'A' + 'a'));
                else name.Append(value[i]);
            return (name.ToString());
        }
        public virtual void OutInfo()
        {
            Console.WriteLine("**************");
            if (Gender)
            {
                Console.WriteLine($"Мистер {Name}{", " + (_isValidDate ? DateOfBirth.ToString("dd/MM/yyyy") + " года рождения, " : "")}вырос за последние {Age} лет,");
                Console.WriteLine($"на {Height} сантиметров, да и растолстел на {Weight} киллограмм");
            }
            else
            {
                Console.WriteLine($"Наша любимейшая {Name}{", " + (_isValidDate ? DateOfBirth.ToString("dd/MM/yyyy") + " года рождения, " : "")}за последние {Age} лет,");
                Console.WriteLine($"стала красивей на {Height} сантиметров, но и слегка поправилась на {Weight} киллограмм");
            }
        }

    }
}
