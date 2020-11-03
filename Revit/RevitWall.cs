﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.Revit
{
  public class RevitWall
  {
    public Level topLevel { get; set; }
    public Dictionary<string, object> parameters { get; set; }
  }
}
