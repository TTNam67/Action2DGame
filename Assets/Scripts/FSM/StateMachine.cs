using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FSM
{
    public class StateMachine : MonoBehaviour
    {
        BaseState _currentState;
        void Start()
        {
            _currentState = GetInitialState();
            if (_currentState != null)
                _currentState.Enter();
        }


        void Update()
        {
            if (_currentState != null)
                _currentState.UpdateLogic();
        }

        void LateUpdate()
        {
            {
                if (_currentState != null)
                    _currentState.UpdatePhysics();
            }
        }

        protected virtual BaseState GetInitialState()
        {
            return null;
        }

        public void ChangeState(BaseState newState)
        {
            _currentState.Exit();

            _currentState = newState;
            _currentState.Enter();
        }

        public BaseState CurrentState()
        {
            return _currentState;
        }
        
    }
}