﻿using System;
using ENode.Eventing;

namespace Registration.SeatAssigning
{
    [Serializable]
    public class SeatUnassigned : DomainEvent<Guid>
    {
        public int Position { get; private set; }

        public SeatUnassigned() { }
        public SeatUnassigned(OrderSeatAssignments source, int position) : base(source)
        {
            Position = position;
        }
    }
}
