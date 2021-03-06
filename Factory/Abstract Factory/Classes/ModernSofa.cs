﻿using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class ModernSofa : ISofa
    {
        public string Name => "Modern sofa";

        public string Purpose()
        {
            return "To lay";
        }
    }
}
