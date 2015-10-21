﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mappings;
using Engine.Mappings.Coordinates;

namespace Engine
{

    public interface IMoveable<T>
    {
        bool try_and_move(ICoordinate<T> end_coord);
        ICoordinate<T> get_current_pos();
    }

    public class TwoDMovementHandler : IMoveable<TwoD>
    {
     
        ICoordinate<TwoD> _pos;
        Movement.IMovementBus<TwoD> _bus;

        public TwoDMovementHandler(Movement.IMovementBus<TwoD> bus, ICoordinate<TwoD> pos)
        {
            _pos = pos;
            _bus = bus;
        }

        public ICoordinate<TwoD> get_current_pos()
        {
            return _pos;
        }

        public bool try_and_move(ICoordinate<TwoD> end_coord)
        {
            Movement.MovementRequest<TwoD> req = new Movement.MovementRequest<TwoD>() { start = get_current_pos(), end = end_coord };
            if (_bus.request_a_move(req))
            {
                _pos = end_coord;
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
