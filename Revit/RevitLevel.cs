﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Objects.Revit
{
  public class RevitLevel : Level
  {
    public bool createView { get; set; }
    public Dictionary<string, object> parameters { get; set; }
  }
}
