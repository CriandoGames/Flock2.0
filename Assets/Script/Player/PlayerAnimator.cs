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


        public void AnimationDie(bool value)
        {
            this.animator.SetBool("die", value);
        }

        public void AnimationFlyer(float value)
        {
            this.animator.SetFloat("flyer", value);
        }
    }
}