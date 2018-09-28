using UnityEngine.UI;

namespace Assets.Script.Player
{
    public class PlayerPartialValues
    {

        public int Score { get; set; }
        //public int Energy { get; set; } -> Uso Futuro

        public void SetScore(Text value)
        {
            Score++;
            value.text = this.Score.ToString();
        }

        public void SetScore(Text value, int score)
        {
            this.Score = this.Score + score;
            value.text = this.Score.ToString();
        }

        public void ResetScore(Text value )
        {
            this.Score = 0;
            value.text = this.Score.ToString();
        }

        public void ResetScore()
        {
            this.Score = 0;
        }


    }
}
