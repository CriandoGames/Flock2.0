using UnityEngine;

namespace Script.Player
{
    public class PlayerScript : PlayerBase, IMotion
    {
          
       public override void Start()
        {
            base.Start();
        }


        private void Update()
        {
            Move();
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