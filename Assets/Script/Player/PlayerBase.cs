using UnityEngine;

namespace Script.Player
{
    public class PlayerBase : MonoBehaviour
    {
        [SerializeField] protected internal float ForceFlayer = new float();


        protected Rigidbody2D rigidbody2D;

        protected Animator animator;

        public virtual void Start()
        {
            this.rigidbody2D = GetComponent<Rigidbody2D>();
            this.animator = GetComponentInChildren<Animator>();

        }

    }
}