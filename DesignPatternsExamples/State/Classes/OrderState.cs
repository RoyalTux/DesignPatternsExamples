using DesignPatternsExamples.State.Interfaces;

namespace DesignPatternsExamples.State.Classes
{
    public class OrderState
    {
        public IOrderState _CurrentState;

        public OrderState()
        {
            _CurrentState = new NewOrder(this);
        }

        public void Dispatch()
        {
            _CurrentState.Dispatch();
        }

        public void Register()
        {
            _CurrentState.Register();
        }

        public void Approve()
        {
            _CurrentState.Approve();
        }
    }
}
