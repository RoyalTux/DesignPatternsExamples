using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes.Victorian
{
    public class VictorianArmchair : IArmchair
    {
        public string Name => "Victorian armchair";

        public string Purpose()
        {
            return "To sit";
        }
    }
}
