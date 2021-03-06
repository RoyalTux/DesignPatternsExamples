﻿using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class VictorianTable : ITable
    {
        public string Name => "Victorian table";

        public string Purpose()
        {
            return "To put";
        }
    }
}
