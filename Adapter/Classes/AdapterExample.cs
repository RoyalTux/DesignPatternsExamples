namespace DesignPatternsExamples.Adapter.Classes
{
    public class AdapterExample
    {
        public void TestAdapterExample()
        {
            var turkey = new WildTurkey();
            var adapter = new TurkeyAdapter(turkey);

            turkey.Fly();
            turkey.Gobble();

            adapter.Fly();
            adapter.Quack();
        }
    }
}
