using FSM;
using UnityEngine;

namespace Player
{
    public class PPatrolState : PAllStates
    {
        protected AudioSource _audioSource;
        
        protected string a_floSpeed = "floSpeed";
        protected string a_floPosX = "floPosX";
        protected string a_floPosY = "floPosY";

        public PPatrolState(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
            _pStateMachine = (PStateMachine) stateMachine;
            
            _audioSource = _pStateMachine._audioSource;
            
            // _pStateMachine.CheckComponentNull(_audioSource);
        }

        public override void Enter()
        {
            base.Enter();
        }

        public override void UpdateLogic()
        {
            base.UpdateLogic();
            
            if (_pStateMachine.CurrentState() != _pStateMachine._PRunState)
            {
                if (Mathf.Abs(_verticalInput) > Mathf.Epsilon ||
                    Mathf.Abs(_horizontalInput) > Mathf.Epsilon)
                {
                    _pStateMachine.ChangeState(_pStateMachine._PRunState);
                }
            }
            else if (_pStateMachine.CurrentState() != _pStateMachine._pIdleState)
            {
                if (Mathf.Abs(_verticalInput) <= Mathf.Epsilon &&
                    Mathf.Abs(_horizontalInput) <= Mathf.Epsilon)
                {
                    _pStateMachine.ChangeState(_pStateMachine._pIdleState);
                }
            }
        }
    }
}