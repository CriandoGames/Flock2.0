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
            score = 0;
            
            textScore.text = score.ToString();
        }

        public void SetScore()
        {
            score++;
            textScore.text = score.ToString();
        }

        public void ResetScore()
        {
            score = 0;
            textScore.text = score.ToString();
        }
        
    }
}