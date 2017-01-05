using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripwires.Games.Wargames.Lib.Types;

namespace Tripwires.Games.Wargames.Lib.Business
{
    public class City
    {
        public string Name { get; private set; }
        private Enums.CityState state;
        public Enums.CityState State {
            get { return this.state; }
            set {
                this.Days = 0;
                this.state = value;
            }
        }
        public int Days { get; private set; }
        public City(string name)
        {
            this.Name = name;
            this.State = Enums.CityState.Uninhabited;
            this.Days = 0;
        }
        public void tick()
        {
            this.Days++;
        }

    }
}
