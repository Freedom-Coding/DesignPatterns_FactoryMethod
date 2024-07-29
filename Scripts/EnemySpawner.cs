using UnityEngine;
using UnityEngine.UI;

namespace FactoryMethodTesting
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private Button spawnButton;
        [SerializeField] private EnemySO enemyToSpawn;

        [SerializeField] private Vector2 spawnPositionMin;
        [SerializeField] private Vector2 spawnPositionMax;

        private EnemyFactory enemyFactory;

        private void Start()
        {
            enemyFactory = new EnemyFactory(new WeaponFactory(), new ArmourFactory());

            spawnButton.onClick.AddListener(SpawnEnemy);
        }

        private void SpawnEnemy()
        {
            Vector2 spawnPosition = new Vector2(Random.Range(spawnPositionMin.x, spawnPositionMax.x), 
                Random.Range(spawnPositionMin.y, spawnPositionMax.y));

            IEnemy iEnemy = enemyFactory.GetEnemy(enemyToSpawn, 1);

            if (iEnemy is MonoBehaviour)
            {
                MonoBehaviour enemy = iEnemy as MonoBehaviour;
                enemy.transform.position = spawnPosition;
            }
        }
    }
}