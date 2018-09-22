using Assets.Game.Script.Res;
using _Game.Script.Res;

namespace _Game.Script.Data
{
    public static class GameController
    {
         public static GameData Data { get; internal set; }
         public static StateMachine CurrentStateMachine { get; set; }
         public static SendMenssageAction SendMenssage { get; set; }
        // public static PlayerPartialValues PartialValues { get; set; }
    }
}