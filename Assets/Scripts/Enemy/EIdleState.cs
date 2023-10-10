using FSM;
using UnityEngine;

namespace Enemy
{
    public class EIdleState : EAllStates
    {
      
        
        public EIdleState(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
           

            
        }
        
        
        
        public override void Enter()
        {
            base.Enter();
        }

        public override void UpdateLogic()
        {
            base.UpdateLogic();
        }

        public override void UpdatePhysics()
        {
            base.UpdatePhysics();
        }
    }
}