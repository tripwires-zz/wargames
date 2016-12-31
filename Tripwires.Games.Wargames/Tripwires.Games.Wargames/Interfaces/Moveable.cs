using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripwires.Games.Wargames.Lib.Types;

namespace Tripwires.Games.Wargames.Lib.Interfaces
{
    interface Moveable
    {
        bool CanMove(Coordinate p);
        bool Move(Coordinate p);
    }
}
