using UnityEngine;

public class BasicEnemyFactory : IEnemyFactory
{
    [SerializeField] private GameObject enemyPrefab;

    public override IEnemy CreateEnemy(Vector3 position)
    {
        GameObject obj = Instantiate(enemyPrefab);
        IEnemy enemy = obj.GetComponent<IEnemy>();
        enemy.Spawn(position);
        return enemy;
    }
}