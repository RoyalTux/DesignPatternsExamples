using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class DefaultArmchair : IArmchair
    {
        public string Name => "Default armchair";

        public string Purpose()
        {
            return "To sit";
        }
    }
}
