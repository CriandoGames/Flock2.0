using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Res
{
    class SpwanController :MonoBehaviour
    {
        [Header("Conf Manager Spawn")]
        [SerializeField]
        private float rateSpawn;
        private float currentRateSawn;
        [SerializeField]
        private int maxSpawnObstacles;
        [SerializeField]
        private GameObject obstaclesPrefabs;
        [Header("Conf Position Obstacles")]
        [SerializeField]
        protected float YPositionMax;
        [SerializeField]
        protected float YPositionMin;

        public List<GameObject> obstacles;

        private void Start()
        {
            SetObstacles();
        }

        private void Update()
        {
            currentRateSawn += Time.deltaTime;

            if (currentRateSawn > rateSpawn){
                currentRateSawn = 0;
                Spawn();
            }
        }

        void SetObstacles()
        {
            for (int i = 0; i < maxSpawnObstacles; i++){
                GameObject tempObstacles = Instantiate(obstaclesPrefabs) as GameObject;
                obstacles.Add(tempObstacles);
                tempObstacles.SetActive(false);
            }
        }

        private void Spawn()
        {
            GameObject tempObstacle = null;
            for (int i = 0; i < maxSpawnObstacles; i++){

                if (obstacles[i].activeSelf == false) {
                    tempObstacle = obstacles[i];
                    break;
                }
            }

            if (tempObstacle != null) {
                float posy = Random.Range(YPositionMin, YPositionMax);
                transform.position = new Vector3(transform.position.x, posy);

                tempObstacle.transform.position = new Vector3(transform.position.x, posy);
                tempObstacle.SetActive(true);
            }
        }
 
    }
}
