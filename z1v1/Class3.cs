using System;
using System.Collections.Generic;
using System.Text;

namespace z1v1
{
    internal class SpecificSport
    {
        private Awards _award;
        public SpecificSport(Awards award, string sport)
        {
            _award = award;
            Sport = sport;
        }
        public string Sport { get;private set; }
        public Awards Award => _award;
        public struct Awards
        {
            private int _gold, _silver, _bronze;
            public Awards(int gold = 0, int silver = 0, int bronze = 0)
            {
                if (gold >= 0) _gold = gold;
                else _gold = 0;
                if (silver >= 0) _silver = silver;
                else _silver = 0;
                if (bronze >= 0) _bronze = bronze;
                else _bronze = 0;
            }

            public int GetGold() => _gold;
            public int GetSilver() => _silver;
            public int GetBronze() => _bronze;
        }
    }
}
