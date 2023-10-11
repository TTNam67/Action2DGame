using FSM;
using UnityEngine;

namespace Player
{
    public class PIdleState : PAllStates
    {
        protected PStateMachine _pStateMachine;
        protected AudioSource _audioSource;
        public PIdleState(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
            _pStateMachine = (PStateMachine) stateMachine;

            _audioSource = _pStateMachine._audioSource;
            if (_audioSource == null)
                Debug.Log("AudioSource: " + _audioSource);
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