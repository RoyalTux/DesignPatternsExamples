using DesignPatternsExamples.State.Interfaces;
using System;

namespace DesignPatternsExamples.State.Classes
{
    public class ApprovedState : IOrderState
    {
        private readonly OrderState _Parent;

        public ApprovedState(OrderState OrderState)
        {
            _Parent = OrderState;
            Approve();
        }

        public void NewOrderPlaced()
        {
            throw new Exception("OrderState has already been placed!");
        }

        public void Dispatch()
        {
            _Parent._CurrentState = new DispatchedState(_Parent);
        }

        public void Register()
        {
            throw new Exception("OrderState has already been registered!");
        }

        public void Approve()
        {
            Console.WriteLine("Approved!");
        }
    }
}
