using FSM;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Player
{
    public class PAllStates : BaseState
    {
        protected PStateMachine _pStateMachine;
        protected AudioSource _audioSource;
        protected Collider2D _collider2D;
        protected Rigidbody2D _rigidbody2D;
        protected Animator _animator;
        protected SpriteRenderer _spriteRenderer;

        protected float _horizontalInput; //Input horizontal
        protected float _verticalInput;
        protected Vector2 _direction;

        protected static float _prevPosX;
        protected static  float _prevPosY;
        
        public PAllStates(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
            _pStateMachine = (PStateMachine) stateMachine;

            _audioSource = _pStateMachine._audioSource;
            _collider2D = _pStateMachine._collider2D;
            _rigidbody2D = _pStateMachine._rigidbody2D;
            _animator = _pStateMachine._animator;
            _spriteRenderer = _pStateMachine._spriteRenderer;
            
            
            // _pStateMachine.CheckComponentNull(_audioSource);
            // _pStateMachine.CheckComponentNull(_collider2D);
            // _pStateMachine.CheckComponentNull(_rigidbody2D);
            // _pStateMachine.CheckComponentNull(_animator);
            // _pStateMachine.CheckComponentNull(_spriteRenderer);
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
            
            _direction.x = _horizontalInput;
            _direction.y = _verticalInput;
            
        }
    }
}