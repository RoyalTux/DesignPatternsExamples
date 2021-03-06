﻿using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class DefaultTable : ITable
    {
        public string Name => "Default table";

        public string Purpose()
        {
            return "To put";
        }
    }
}
