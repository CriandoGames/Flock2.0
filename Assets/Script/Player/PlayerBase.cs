using UnityEngine;

namespace Script.Player
{
    public abstract class PlayerBase : MonoBehaviour , IMotion
    {
        [SerializeField] protected internal float ForceFlayer = new float();

        protected Rigidbody2D rigidbody2D;

        protected Animator animator;
        
        protected PlayerAnimator playerAnimator;

        public virtual void Start()
        {
            animator = GetComponentInChildren<Animator>();
            
            playerAnimator = new PlayerAnimator(animator);
            
            this.rigidbody2D = GetComponent<Rigidbody2D>();
            
        }
        
        public void Move()
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerAnimator.AnimationFlyer(ForceFlayer);
                
                rigidbody2D.AddForce(new Vector2(0,ForceFlayer)); 
            }
        }

    }
}