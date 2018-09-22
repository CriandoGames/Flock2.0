//using Assets.Game.Script.Player;

using _Game.Script.Res;
using Assets.Game.Script.Res;
using Assets.Script.Player;

namespace _Game.Script.Data
{
    class GameDataInitialize
    {
        internal GameData Start()
        {
            return new GameData
            {
                Sound = true,
                HightScore = 0,

            };
        }

        internal void Set(GameData data)
        {
            GameController.CurrentStateMachine = new StateMachine();
            GameController.Data = data;
            GameController.PartialValues = new PlayerPartialValues();
           // GameController.PartialValues.ResetScore();
            GameController.SendMenssage = new SendMenssageAction();

        }
    }
}
