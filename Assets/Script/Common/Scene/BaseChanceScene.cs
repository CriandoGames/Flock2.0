using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Script.Res;

namespace Script.Common
{
    public class BaseChanceScene : MonoBehaviour
    {
        [SerializeField] private EnumNameScene NameScene;
        [SerializeField] protected float waitTime;


        public virtual void Start()
        {
            StartCoroutine(ChangeScene());
        }


        protected IEnumerator ChangeScene()
        {
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene(NameScene.ToString());
        }
    }
}