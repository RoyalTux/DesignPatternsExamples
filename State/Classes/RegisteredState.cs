using DesignPatternsExamples.State.Interfaces;
using System;

namespace DesignPatternsExamples.State.Classes
{
    public class RegisteredState : IOrderState
    {
        private readonly OrderState _Parent;

        public void NewOrderPlaced()
        {
            throw new Exception("OrderState has already been placed!");
        }

        public RegisteredState(OrderState OrderState)
        {
            _Parent = OrderState;
            Register();
        }

        public void Dispatch()
        {
            throw new Exception("OrderState has not been registered yet!");
        }

        public void Register()
        {
            Console.WriteLine("Registered!");
        }

        public void Approve()
        {
            _Parent._CurrentState = new ApprovedState(_Parent);
        }
    }
}
