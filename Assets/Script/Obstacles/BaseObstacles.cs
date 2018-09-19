using Assets.Script.Common.CammonInterface;
using Script.Player;
using UnityEngine;

namespace Assets.Script.Obstacles
{
    [RequireComponent(typeof(Rigidbody2D))]
   public abstract class BaseObstacles : MonoBehaviour , Score
    {

        [Header("Config Obstacle")]
        [SerializeField]
        protected float Speed;
        [SerializeField]
        protected float LimiteScreem;

        protected new Rigidbody2D rigidbody;


        [Header("Config Score")]
        protected GameObject playerPosition;
        protected bool isPass;

        protected void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();
            playerPosition = GameObject.Find("Player");
            
            
        }

        protected void FixedUpdate()
        {
            Mov();
            SetOff();
        }

        protected void Mov()
        {
            rigidbody.velocity = new Vector2(Speed, 0);
            Set(1);
        }

        protected void SetOff()
        {
            if (transform.position.x <= LimiteScreem){
                isPass = false;
                gameObject.SetActive(false);
            }
        }

        public void Set(int value)
        {

            if (transform.position.x <= playerPosition.transform.position.x && isPass == false)
            {
                isPass = true;
                //implemenatar Pontos

            }
        }
    }
}
