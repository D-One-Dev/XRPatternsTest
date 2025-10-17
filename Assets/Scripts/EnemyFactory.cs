using UnityEngine;

public abstract class IEnemyFactory : MonoBehaviour
{
    public abstract IEnemy CreateEnemy(Vector3 position);
}