using UnityEngine;

namespace _Game.Script.Data
{
    class StartGameDataScript :MonoBehaviour
    {
        private void Start()
        {
         
            GameSaveLoad.Load();
        }
    }
}
