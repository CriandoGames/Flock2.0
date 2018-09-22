
using _Game.Script.Data;
using Assets.Script.Res;
using UnityEngine;

namespace _Game.Script.Res
{
    public class SendMenssageAction
    {
       
        public void SetWindownOff()
        {
          //  Debug.Log("ENTROU");
           // var manager = GameObject.FindGameObjectWithTag(EnumObjectTagResource.WindowAlertInCanvas.ToString());
           // manager.SendMessage("SetWindownOff");

        }

        public void StartGame()
        {
            SetWindownOff();
            GameController.CurrentStateMachine.state = EnumStateMachine.INGAME;
           // GameController.PartialValues.ResertScore();
        }

        public void RestartGame()
        {
          
        }

        public void SetGameOver()
        {
           

        }

        public void CallExitGame()
        {
            
        }

        public void SetScore()
        {
            var manager = GameObject.FindGameObjectWithTag(EnumObjectTagResource.Manager.ToString());
            manager.SendMessage("AddScore");
        }

    }
}
