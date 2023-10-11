using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

using FSM;

namespace Player
{
    public class PStateMachine : StateMachine
    {

        [HideInInspector] public PIdleState _pIdleState;
        [HideInInspector] public PRunState _PRunState;

        public AudioSource _audioSource;
        public Collider _collider;
        public Rigidbody2D _rigidbody2D;
        public Animator _animator;
        public SpriteRenderer _spriteRenderer;


        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
            if (_audioSource == null)
                Debug.Log("AudioSource: " + _audioSource);

            _collider = GetComponent<Collider>();
            if (_collider == null)
                Debug.Log("Collider: " + _collider);

            _rigidbody2D = GetComponent<Rigidbody2D>();
            if (_rigidbody2D == null)
                Debug.Log("Rigidbody2D: " + _rigidbody2D);

            _animator = GetComponent<Animator>();
            if (_animator == null)
                Debug.Log("Animator: " + _animator);

            _spriteRenderer = GetComponent<SpriteRenderer>();
            if (_spriteRenderer == null)
                Debug.Log("SpriteRenderer");
            



            _pIdleState = new PIdleState("PIdleState", this);
            _PRunState = new PRunState("PRunState", this);

        }


        protected override BaseState GetInitialState()
        {
            return _pIdleState;
        }





    }
}
