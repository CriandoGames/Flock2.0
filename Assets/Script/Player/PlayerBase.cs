using UnityEngine;
using System;
using Assets.Script.Player;

namespace Script.Player
{

    public enum Tag
    {
        OBSTACULOS,
        COIN
    }

    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class PlayerBase : MonoBehaviour , IMotion , IDamage
    {
        [Header("Config Player")]

        [SerializeField]
        protected internal float ForceFlayer = new float();

        protected new Rigidbody2D rigidbody2D;

        protected Animator animator;
        
        protected PlayerAnimator playerAnimator;

        public void Start()
        {
            animator = GetComponentInChildren<Animator>();
            
            playerAnimator = new PlayerAnimator(animator);
            
            this.rigidbody2D = GetComponent<Rigidbody2D>();
            
        }

        private void FixedUpdate()
        {
            Move();
        }

        public void Move()
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerAnimator.AnimationFlyer();
                
                rigidbody2D.AddForce(new Vector2(0,ForceFlayer)); 
            }
        }

        protected void OnTriggerEnter2D(Collider2D collider)
        {

         if(collider.CompareTag(Tag.OBSTACULOS.ToString())){
                Damage();
           }

        }

        public void Damage()
        {
            playerAnimator.AnimationDie();
        }
    }
}