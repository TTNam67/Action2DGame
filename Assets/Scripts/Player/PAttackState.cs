using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

using FSM;

namespace Player
{
    public class PAttackState : PAllStates
    {
        protected string a_Attack = "booAttack";
        protected string a_AttackCombo = "floAttackCombo";
        
        protected float _timeLimit = 0.5f;
        
        
        public PAttackState(string name, StateMachine stateMachine) : base(name, stateMachine)
        {
            
            
        }

        public override void Enter()
        {
            base.Enter();
            _animator.SetBool(a_Attack, true);
            
            if (_timeCountAttackCombo < _timeLimit)
            {
                _countAttackCombo += 1.1f;
                if (_countAttackCombo >= 3f)
                    _countAttackCombo = 0.1f;
            }
            
            _animator.SetFloat(a_AttackCombo, _countAttackCombo);
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

        public override void Exit()
        {
            base.Exit();
            _animator.SetBool(a_Attack, false);
        }
    }
}