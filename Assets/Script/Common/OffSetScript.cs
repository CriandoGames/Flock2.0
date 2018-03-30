using UnityEngine;

namespace Script.Common
{
    public class OffSetScript : MonoBehaviour
    {
        [SerializeField]
        private float speed;
        
        //private 
        private Material material;
        private float offSet;
        
        
        void Awake()
        {
            material = GetComponent<Renderer>().material;

            if (material == null)
                return;

        }
        
        
        void FixedUpdate()
        {
            offSet += 0.01f;
            material.SetTextureOffset("_MainTex", new Vector2(offSet * speed, 0));

        }
        
        

    }
}