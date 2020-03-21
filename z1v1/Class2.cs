using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace z1v1
{
    sealed
        internal class Sportsman : Human, IComparable<Sportsman>
    {
        /*      public struct SpecificSport
              {

              }*/
        private List<SpecificSport> _SpecificSport = new List<SpecificSport>();
        // private List<string> _sports = new List<string>();
        // private List<Award> _awards = new List<Award>();
        private int _score;
        public Sportsman(int age, int weight, int height, string name, params SpecificSport[] sports) : base(age, weight, height, name)
        {
            for (int i = 0; i < sports.Length; i++)
                this[sports[i].Sport] = sports[i].Award;
        }
        public Sportsman(Human human, params SpecificSport[] sports) : base(human.Age, human.Weight, human.Height, human.Name)
        {
            for (int i = 0; i < sports.Length; i++)
                this[sports[i].Sport] = sports[i].Award;
        }

        //~Sportsman()
        //{
        //suicide();
        // Console.WriteLine("Commited suicide");
        //}
        public int Length() => _SpecificSport.Count;
        static public int CountScore(int gold, int silver, int bronze) => 3 * gold + 2 * silver + bronze;
        //  public static Award SetAwards(int gold, int silver, int bronze) => new Award(gold, silver, bronze);

        public int Find(string value)
        {
            for (int i = 0; i < _SpecificSport.Count; i++)
            {
                if (_SpecificSport[i].Sport == value) return i;
            }
            return -1;
        }
        public SpecificSport.Awards this[string ind]
        {
            set
            {
                int i = Find(ind);
                if (i == -1)
                {
                    _SpecificSport.Add(new SpecificSport(value, ind));
                    _score += CountScore(_SpecificSport[Length() - 1].Award.GetGold(), _SpecificSport[Length() - 1].Award.GetSilver(), _SpecificSport[Length() - 1].Award.GetBronze());
                }
                else
                {
                    _score -= CountScore(_SpecificSport[i].Award.GetGold(), _SpecificSport[i].Award.GetSilver(), _SpecificSport[i].Award.GetBronze());
                    _SpecificSport.RemoveAt(i);
                    _SpecificSport.Insert(i, new SpecificSport(value, ind));
                    _score += CountScore(_SpecificSport[i].Award.GetGold(), _SpecificSport[i].Award.GetSilver(), _SpecificSport[i].Award.GetBronze());
                }
            }
            get
            {
                int i = Find(ind);
                return i == -1 ? new SpecificSport.Awards() : _SpecificSport[i].Award;
            }
        }

        public new void OutInfo()
        {
            base.OutInfo();
            for (int i = 0; i < Length(); i++)
            {
                //Console.WriteLine($"{_sports[i]}: {_awards[i]}\n");
                Console.WriteLine($"{_SpecificSport[i].Sport}: gold medals = {_SpecificSport[i].Award.GetGold()}, silver medals = {_SpecificSport[i].Award.GetSilver()}, bronze medals = {_SpecificSport[i].Award.GetBronze()}");
            }
            Console.WriteLine($"Total score:{_score}");
        }
        // public IEnumerator GetEnumerator() => _awards.GetEnumerator();
        public static bool operator <(Sportsman s1, Sportsman s2) => s1._score < s2._score;
        public static bool operator >(Sportsman s1, Sportsman s2) => s1._score > s2._score;
        public int CompareTo(Sportsman compareSportsman) => compareSportsman == null ? 1 : _score - compareSportsman._score;
    }

}

