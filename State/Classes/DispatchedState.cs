using DesignPatternsExamples.State.Interfaces;
using System;

namespace DesignPatternsExamples.State.Classes
{
    public class DispatchedState : IOrderState
    {
        private readonly OrderState _Parent;

        public void NewOrderPlaced()
        {
            throw new Exception("OrderState has already been placed!");
        }

        public DispatchedState(OrderState OrderState)
        {
            _Parent = OrderState;
            Dispatch();
        }

        public void Dispatch()
        {
            Console.WriteLine("Dispatched!");
        }

        public void Register()
        {
            throw new Exception("OrderState has already been registered!");
        }

        public void Approve()
        {
            _Parent._CurrentState = new ApprovedState(_Parent);
        }
    }
}
