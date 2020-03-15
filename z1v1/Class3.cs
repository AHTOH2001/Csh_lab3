using System;
using System.Collections.Generic;
using System.Text;

namespace z1v1
{
    public class SpecificSport
    {
        private Award _award;
        private SpecificSport(Award award, string sport)
        {
            _award = award;
            Sport = sport;
        }
        private string Sport { get; private set; }
        private Award Award
        {
            get => _award;
        }
        private struct Award
        {
            private int _gold, _silver, _bronze;
            public Award(int gold = 0, int silver = 0, int bronze = 0)
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
