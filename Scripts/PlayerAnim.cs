using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
namespace Player
{
    public class PlayerAnim : Pl
    {
        // Start is called before the first frame update
        private Animator _animator;
        void Start()
        {
            _animator = GetComponent<Animator>();
            _animator.SetBool("Left", false);


        }


        public override void MoveUp()
        {
            _animator.SetBool("Run", true);
            _animator.SetBool("Idle", false);
            _animator.SetBool("Up", true);
            


        }
        public override void MoveDown()
        {
            _animator.SetBool("Run", true);
            _animator.SetBool("Idle", false);
            _animator.SetBool("Up", false);



        }
        public override void MoveLeft()
        {
            _animator.SetBool("Run", true);
            _animator.SetBool("Idle", false);
            _animator.SetBool("Left", true);


        }
        public override void MoveRight()
        {
            _animator.SetBool("Run", true);
            _animator.SetBool("Idle", false);
            _animator.SetBool("Left", false);


        }
        public override void Kick()
        {

        }

        private void LateUpdate()
        {
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) &&
                !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) &&
                !Input.GetKey(KeyCode.F))
            {
                _animator.SetBool("Run", false); // —брос анимации бега
                _animator.SetBool("Idle", true);

            }
        }
    }
}
