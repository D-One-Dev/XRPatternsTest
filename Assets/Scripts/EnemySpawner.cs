using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private BasicEnemyFactory factory;

    private void Start()
    {
        GameEventManager.Instance.OnEnemyDestroyed += OnEnemyDestroyed;
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        Vector3 position = new Vector3(Random.Range(-5, 5), 0.25f, Random.Range(-5, 5));
        IEnemy newEnemy = factory.CreateEnemy(position);

        IEnemy fastEnemy = new FastEnemyDecorator(newEnemy);
        fastEnemy.Spawn(position);
    }

    private void OnEnemyDestroyed(IEnemy enemy)
    {
        Debug.Log("Enemy destroyed, new spawns in 2s");
        Invoke(nameof(SpawnEnemy), 2f);
    }

    private void OnDestroy()
    {
        GameEventManager.Instance.OnEnemyDestroyed -= OnEnemyDestroyed;
    }
}
