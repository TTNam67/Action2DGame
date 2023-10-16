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
        protected string a_dash = "triDash";
        protected string a_isMoving = "booIsMoving";

        protected float _speed = 7f;
        protected float _runSpeed = 7f;
        protected float _dashSpeed = 130f;

        public PPatrolState(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
            // _pStateMachine = (PStateMachine) stateMachine;
            
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

            if (_pStateMachine.CurrentState() == _pStateMachine._pDashState)
            {
                return;
            }
            
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

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _pStateMachine.ChangeState(_pStateMachine._pDashState);
            }
            
        }
    }
}