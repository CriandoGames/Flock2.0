using UnityEngine;

namespace Script.Player
{
    public class PlayerScript : PlayerBase
    {
        new void Start()
        {
            base.Start();
        }

        void Update()
        {
            Move();
        }


     
    }
}