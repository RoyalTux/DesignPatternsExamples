using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class ModernArmchair : IArmchair
    {
        public string Name => "Modern armchair";

        public string Purpose()
        {
            return "To sit";
        }
    }
}
