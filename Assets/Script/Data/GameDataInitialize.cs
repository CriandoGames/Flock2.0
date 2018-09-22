//using Assets.Game.Script.Player;

using Assets.Game.Script.Res;

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
           // GameController.PartialValues = new PlayerPartialValues();
           // GameController.PartialValues.ResertScore();
           // GameController.SendMenssage = new SendMenssageAction();

        }
    }
}
