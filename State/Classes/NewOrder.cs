using DesignPatternsExamples.State.Interfaces;
using System;

namespace DesignPatternsExamples.State.Classes
{
    public class NewOrder : IOrderState
    {
        private readonly OrderState _Parent;

        public NewOrder(OrderState OrderState)
        {
            _Parent = OrderState;
            NewOrderPlaced();
        }

        public bool IsDispatched
        {
            get { return false; }
        }

        public void NewOrderPlaced()
        {
            Console.WriteLine("New order placed!");
        }

        public void Dispatch()
        {
            _Parent._CurrentState = new DispatchedState(_Parent);
        }

        public void Register()
        {
            _Parent._CurrentState = new RegisteredState(_Parent);
        }

        public void Approve()
        {
            _Parent._CurrentState = new ApprovedState(_Parent);
        }
    }
}
