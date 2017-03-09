﻿using System;
using System.Globalization;

namespace IllyumL2T.Core.FieldsSplit.UnitTests
{
  [IllyumL2T.Core.FileParseBehavior(BlankLineMode = BlankLineMode.Nulled)]
  class ShipmentNulled
  {
    public short OrderId { get; set; }

    [IllyumL2T.Core.ParseBehavior(NumberStyle = NumberStyles.AllowDecimalPoint)]
    public decimal Freight { get; set; }

    public string ShipAddress { get; set; }

    [IllyumL2T.Core.ParseBehavior(DateTimeFormat = "d/M/yyyy")]
    public DateTime DeliveryDate { get; set; }

    public override bool Equals(object other)
    {
      if (other is ShipmentNulled)
      {
        return ((ShipmentNulled)other).GetHashCode() == this.GetHashCode();
      }

      return false;
    }

    public override int GetHashCode()
    {
      return OrderId.GetHashCode() +
             Freight.GetHashCode() +
             ShipAddress.GetHashCode() +
             DeliveryDate.GetHashCode();
    }
  }
}