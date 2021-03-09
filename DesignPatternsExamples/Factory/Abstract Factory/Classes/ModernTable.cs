using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class ModernTable : ITable
    {
        public string Name => "Modern table";

        public string Purpose()
        {
            return "To put";
        }
    }
}
