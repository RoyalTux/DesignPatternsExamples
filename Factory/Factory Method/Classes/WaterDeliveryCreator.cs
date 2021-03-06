﻿using DesignPatternsExamples.Factory.Factory_Method.Interfaces;

namespace DesignPatternsExamples.Factory.Factory_Method.Classes
{
    public class WaterDeliveryCreator : Creator
    {
        public override IDelivery FactoryMethod()
        {
            return new WaterDelivery();
        }
    }
}
