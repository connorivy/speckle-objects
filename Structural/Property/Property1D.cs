﻿using Speckle.Newtonsoft.Json;
using Speckle.Core.Kits;
using Speckle.Core.Models;
using System.Collections.Generic;
using Objects.Structural.Geometry;
using Objects.Structural.Materials;

namespace Objects.Structural.Properties
{
    public class Property1D : Property //SectionProperty as alt class name
    {
        public MemberType memberType { get; set; }

        [DetachProperty]
        public Material material { get; set; }
        public string grade { get; set; } //design material

        [DetachProperty]
        public SectionProfile profile { get; set; } //section description
        public BaseReferencePoint referencePoint { get; set; }
        public double offsetY { get; set; } = 0; //offset from reference point
        public double offsetZ { get; set; } = 0; //offset from reference point
        public double area { get; set; }
        public double Iyy { get; set; }
        public double Izz { get; set; }
        public double J { get; set; }
        public double Ky { get; set; }
        public double Kz { get; set; }

        public Property1D() { }

        [SchemaInfo("Property1D (by name)", "Creates a Speckle structural 1D element property")]
        public Property1D(string name)
        {
            this.name = name;
        }

        [SchemaInfo("Property1D", "Creates a Speckle structural 1D element property")]
        public Property1D(string name, Material material, SectionProfile profile)
        {
            this.name = name;
            this.material = material;
            this.profile = profile;
        }
    }
}
