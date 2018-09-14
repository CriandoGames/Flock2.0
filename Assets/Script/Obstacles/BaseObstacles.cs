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
        protected float YPositionMax;
        [SerializeField]
        protected float YPositionMin;

        protected new Rigidbody2D rigidbody;


        protected void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
            SetConfig();
        }

        protected void FixedUpdate()
        {
            Mov();
        }

        protected void SetConfig()
        {

            float posy = Random.Range(YPositionMin, YPositionMax);
            transform.position = new Vector3(transform.position.x, posy);
        }
       
        protected void Mov()
        {
            rigidbody.velocity = new Vector2(Speed, 0);
        }

    

    }
}
