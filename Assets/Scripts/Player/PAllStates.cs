using FSM;
using UnityEngine;

namespace Player
{
    public class PAllStates : BaseState
    {
        protected PStateMachine _pStateMachine;
        protected AudioSource _audioSource;
        protected Collider _collider;
        protected Rigidbody2D _rigidbody2D;
        protected Animator _animator;
        protected SpriteRenderer _spriteRenderer;

        protected float _horizontalInput;
        protected float _verticalInput;
        
        
        public PAllStates(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
            _pStateMachine = (PStateMachine) stateMachine;

            _audioSource = _pStateMachine._audioSource;
            if (_audioSource == null)
                Debug.Log("AudioSource: " + _audioSource);

            _collider = _pStateMachine._collider;
            if (_collider == null)
                Debug.Log("Collider: " + _collider);

            _rigidbody2D = _pStateMachine._rigidbody2D;
            if (_rigidbody2D == null)
                Debug.Log("Rigidbody2D: " + _rigidbody2D);

            _animator = _pStateMachine._animator;
            if (_animator == null)
                Debug.Log("Animator: " + _animator);

            _spriteRenderer = _pStateMachine._spriteRenderer;
            if (_spriteRenderer == null)
                Debug.Log("SpriteRenderer");
        }
            
        public override void Enter()
        {
            base.Enter();
        }

        public override void UpdateLogic()
        {
            base.UpdateLogic();
            _horizontalInput = Input.GetAxis("Horizontal");
            _verticalInput = Input.GetAxis("Vertical");
            
            

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