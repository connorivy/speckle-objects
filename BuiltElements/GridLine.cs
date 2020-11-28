﻿using Objects.Geometry;
using Speckle.Core.Kits;
using Speckle.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.BuiltElements
{
  public class GridLine : Base
  {
    public Line baseLine { get; set; }

    [SchemaOptional]
    public Level level { get; set; }

    public GridLine(Line baseLine, Level level = null)
    {
      this.baseLine = baseLine;
      this.level = level;
    }
  }
}
