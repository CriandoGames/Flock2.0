using System.Runtime.Serialization.Formatters;
using UnityEngine;

namespace Script.Player
{
    public abstract class PlayerControll : PlayerBase
    {
        public abstract void Move();


        public virtual void AnimationDie(bool value, Animator animator)
        {
            animator.SetBool("die", value);
        }

        public virtual void AnimationFlyer(float value, Animator animator)
        {
            animator.SetFloat("flyer", value);
        }
    }
}