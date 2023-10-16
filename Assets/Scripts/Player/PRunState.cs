using FSM;
using UnityEngine;

namespace Player
{
    public class PRunState : PPatrolState
    {
        
        // private float _speed = 7f;
        
        public PRunState(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
            _speed = _runSpeed; 

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

            
            _animator.SetFloat(a_floSpeed, _direction.magnitude);

            if (_horizontalInput > 0)
                _prevPosX = 1;
            else if (_horizontalInput < 0)
                _prevPosX = -1;

            if (_verticalInput > 0)
                _prevPosY = 1;
            else if (_verticalInput < 0)
                _prevPosY = -1;
        }

        public override void UpdatePhysics()
        {
            base.UpdatePhysics();
            _rigidbody2D.AddForce(_direction * _speed);
        }

        public override void Exit()
        {
            base.Exit();
            
            
        }
    }
}