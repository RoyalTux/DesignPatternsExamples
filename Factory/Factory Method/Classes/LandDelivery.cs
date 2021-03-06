using DesignPatternsExamples.Factory.Factory_Method.Interfaces;

namespace DesignPatternsExamples.Factory.Factory_Method.Classes
{
    public class LandDelivery : IDelivery
    {
        public string DeliveryType()
        {
            return "Will deliver by land";
        }
    }
}
