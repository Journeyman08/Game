﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Geometry;
using Engine.Player;

namespace Engine.Unit.Custom.Draughts
{
       
    public class Man : IEntity
    {

        protected IPoint _pos;

        public Man(IPoint pos)
        {
            _pos = pos;
        }

        public IPoint get_pos()
        {
            return _pos;
        }

        public TwoPlayers get_side()
        {
            throw new NotImplementedException();
        }

        public bool move_in_direction(Direction direction)
        {
            _pos = _pos.get_next_point_in_direction(direction);
            return true;
        }
    }

}
