using DesignPatternsExamples.Factory.Factory_Method.Interfaces;

namespace DesignPatternsExamples.Factory.Factory_Method.Classes
{
    public abstract class Creator
    {
        public abstract IDelivery FactoryMethod();

        public string SomeOperation()
        {
            var delivery = FactoryMethod();
            var result = "Created delivery type:  " + delivery.DeliveryType();

            return result;
        }
    }
}
