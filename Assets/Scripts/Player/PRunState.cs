using FSM;
using UnityEngine;

namespace Player
{
    public class PRunState : PAllStates
    {
        protected PStateMachine _pStateMachine;
        protected AudioSource _audioSource;

        private string a_floSpeed = "floSpeed";
        private string a_floPosX = "floPosX";
        private string a_floPosY = "floPosY";
        
        private Vector2 _direction;
        private float _speed = 7f;
        
        public PRunState(string name, StateMachine stateMachine) : base(name, stateMachine)
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
            _animator.SetFloat(a_floPosX, _horizontalInput);
            _animator.SetFloat(a_floPosY, _verticalInput);

            _direction.x = _horizontalInput;
            _direction.y = _verticalInput;
            _animator.SetFloat(a_floSpeed, _direction.magnitude);
        }

        public override void UpdatePhysics()
        {
            base.UpdatePhysics();
            _rigidbody2D.AddForce(_direction * _speed);
        }
    }
}