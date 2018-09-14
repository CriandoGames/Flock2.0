using UnityEngine;

namespace Script.Player
{
    public sealed class PlayerAnimator
    {

        private Animator animator;


        public PlayerAnimator(Animator value)
        {
            this.animator = value;
        }


        public void AnimationDie()
        {
            this.animator.SetTrigger("Die");
        }

        public void AnimationFlyer()
        {
            this.animator.SetTrigger("Flying");
        }
    }
}