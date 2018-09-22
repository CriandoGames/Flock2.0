using _Game.Script.Data;
using UnityEngine;
using UnityEngine.UI;

namespace _Game.Script.Common
{
    public class ScoreManagerScript : MonoBehaviour
    {
        [SerializeField]
        private Text textScore;
        
        private byte score;

        private void Start()
        {
            GameController.PartialValues.ResetScore(textScore);
        }

        public void AddScore()
        {
            GameController.PartialValues.SetScore(textScore);
                
        }
        
    }
}