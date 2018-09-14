using UnityEngine;

namespace Assets.Script.Obstacles
{
    [RequireComponent(typeof(Rigidbody2D))]
   public abstract class BaseObstacles : MonoBehaviour
    {

        [Header("Config Obstacle")]
        [SerializeField]
        protected float Speed;
        [SerializeField]
        protected float LimiteScreem;

        protected new Rigidbody2D rigidbody;


        protected void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }

        protected void FixedUpdate()
        {
            Mov();
            SetOff();
        }

        protected void Mov()
        {
            rigidbody.velocity = new Vector2(Speed, 0);
        }

        protected void SetOff()
        {
            if (transform.position.x <= LimiteScreem){
                gameObject.SetActive(false);
            }
        }


    }
}
