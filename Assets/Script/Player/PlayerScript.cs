using UnityEngine;

namespace Script.Player
{
    public class PlayerScript : PlayerControll
    {
       
        
        public override void Start()
        {
            base.Start();
        }


        private void Update()
        {
            Move();
        }

        public override void Move()
        {
            if (Input.GetMouseButtonDown(0))
            {
                AnimationFlyer(ForceFlayer,animator);
                
                rigidbody2D.AddForce(new Vector2(0,ForceFlayer)); 
            }
        }
    }
}