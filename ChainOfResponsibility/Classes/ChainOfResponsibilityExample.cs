namespace DesignPatternsExamples.ChainOfResponsibility.Classes
{
    public class ChainOfResponsibilityExample
    {
        public void TestChainOfResponsibility()
        {
            Approver kirill = new Director();
            Approver petya = new VicePresident();
            Approver vasya = new President();

            kirill.SetSuccessor(petya);
            petya.SetSuccessor(vasya);

            var purchase = new Purchase(2034, 350.00, "Project X");
            kirill.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32590.10, "Project Y");
            kirill.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122100.00, "Project Z");
            kirill.ProcessRequest(purchase);
        }
    }
}
