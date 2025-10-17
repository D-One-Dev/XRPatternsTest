using UnityEngine;

public class BasicEnemy : MonoBehaviour, IEnemy
{
    public int health = 100;

    public void Spawn(Vector3 position)
    {
        transform.position = position;
        Debug.Log($"Enemy spawned at position {position}");
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log($"Enemy got {amount} damage. {health} HP left.");

        if (health <= 0)
        {
            GameEventManager.Instance.NotifyEnemyDestroyed(this);
            Destroy(gameObject);
        }
    }
}