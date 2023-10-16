using FSM;
using UnityEngine;

namespace Player
{
    public class PIdleState : PPatrolState
    {
        // protected PStateMachine _pStateMachine;
        
        public PIdleState(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
            // _pStateMachine = (PStateMachine) stateMachine;
            
        }
        
        public override void Enter()
        {
            base.Enter();
            _rigidbody2D.velocity = _rigidbody2D.velocity * 0.5f;
            
            
            
            
        }

        public override void UpdateLogic()
        {
            base.UpdateLogic();
            _animator.SetFloat(a_floPosX, _prevPosX);
            _animator.SetFloat(a_floPosY, _prevPosY);
            
        }

        public override void UpdatePhysics()
        {
            base.UpdatePhysics();
        }
    }
}