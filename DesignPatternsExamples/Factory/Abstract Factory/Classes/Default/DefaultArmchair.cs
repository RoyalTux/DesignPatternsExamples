using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes.Default
{
    public class DefaultArmchair : IArmchair
    {
        public string Name => "Default armchair";

        public string Purpose(int numbersOfHandles)
        {
            return "To sit";
        }
    }
}
