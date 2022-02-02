using System.Collections.Generic;
using Objects.Geometry;
using Speckle.Core.Models;

namespace Objects.BuiltElements.Archicad
{
	public class DirectShape : Base
	{
		public string ElementId { get; set; }

		public List<Mesh> displayValue { get; set; }

		public DirectShape() { }

		public DirectShape(string elementId, List<Mesh> displayValue)
		{
			ElementId = elementId;
			this.displayValue = displayValue;
		}
	}
}
